# A* Pathfinding Visualization

This project demonstrates the A* pathfinding algorithm using a grid-based visualization. Users can set obstacles, a start point, and an endpoint on the grid, and the algorithm will find a path between the start and end points, visualizing the process step by step.

## Getting Started

To run this project locally, follow these steps:

1. Clone the repository to your local machine.
2. Open the `index.html` file in a web browser.
3. Follow the instructions on the page to set obstacles, start and end points, and find the path.

Here are some screenshots of the project in action:

1. Initial Grid Setup:
   
   ![A1](https://github.com/ghislainclaude/Astar_Pathfinding-/assets/45498219/c46773ae-c307-4a70-a965-6822ef1f836c)

2. Setting Start and End Points: Shift mouse down(Start-point) and Control mouse down(End-Point)
   ![A2](https://github.com/ghislainclaude/Astar_Pathfinding-/assets/45498219/7eb7d40c-7823-4800-8cc2-05ddccb86354)

3. Adding Obstacles: Mouse down 

4. Finding the Path:
  
   ![A3](https://github.com/ghislainclaude/Astar_Pathfinding-/assets/45498219/b9f57f3a-5d3d-4a34-b076-b8138b5aca00)


## Adjusting Animation Speed

If you want to adjust the animation speed of the A* pathfinding visualization, you can modify the `pathAnimationInterval` variable in the `index.html` file. Increasing the interval value will slow down the animation, and decreasing it will speed it up. Locate the following line of code in the `<script>` section:

```javascript
const pathAnimationInterval = 100; // Adjust the interval to control the visualization speed

