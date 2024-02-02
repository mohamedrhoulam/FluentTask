import React from 'react';
import './TaskList.css';

const TaskListItem = ({ task }) => {
  return (
    <div className="task-list-item">
      <span className={`task-item-checkbox ${task.completed ? 'completed' : ''}`}></span>
      <div className="task-item-content">
        <p className={`task-item-title ${task.completed ? 'completed' : ''}`}>{task.title}</p>
        <div className="task-item-actions">
          //
        </div>
      </div>
    </div>
  );
};

export default TaskListItem;
