using AStarPathfinding.Models;
using AStarPathfinding.Nodes;
using Microsoft.AspNetCore.Mvc;

namespace AStarPathfinding.Controllers
{
    public class GridController : Controller
    {
        private GridModel gridModel;
        public GridController()
        {
            gridModel = new GridModel(10, 10);
        }
        public ActionResult Index()
        {
            return View(gridModel);
        }
        //[HttpPost]
        //public ActionResult ToggleNode(int x, int y)
        //{
        //    var node = gridModel.Nodes[x, y];

        //    if (node == gridModel.StartNode)
        //    {
        //        gridModel.StartNode = null;
        //    }
        //    else if (node == gridModel.EndNode)
        //    {
        //        gridModel.EndNode = null;
        //    }
        //    else if (node.IsObstacle)
        //    {
        //        node.IsObstacle = false;
        //    }
        //    else if (gridModel.StartNode == null)
        //    {
        //        gridModel.StartNode = node;
        //    }
        //    else if (gridModel.EndNode == null)
        //    {
        //        gridModel.EndNode = node;
        //    }
        //    else
        //    {
        //        node.IsObstacle = true;
        //    }
        //    return Json(new { success = true });
        //}
        // Other actions...

        [HttpPost]
        public ActionResult ToggleNode(int x, int y)
        {
            // Toggle obstacle when mouse is clicked
            var node = gridModel.Nodes[x, y];
            node.IsObstacle = !node.IsObstacle;
            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult SetStartNode(int x, int y)
        {
            // Set the start node
            gridModel.StartNode = gridModel.Nodes[x, y];

            // Reset end node if it's the same as the new start node
            if (gridModel.StartNode == gridModel.EndNode)
                gridModel.EndNode = null;

            return Json(new { success = true });
        }

        [HttpPost]
        public ActionResult SetEndNode(int x, int y)
        {
            // Set the end node
            gridModel.EndNode = gridModel.Nodes[x, y];

            // Reset start node if it's the same as the new end node
            if (gridModel.EndNode == gridModel.StartNode)
                gridModel.StartNode = null;

            return Json(new { success = true });
        }
    }
}
