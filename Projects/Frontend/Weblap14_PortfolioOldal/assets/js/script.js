document.querySelectorAll('a[href^="#"]').forEach(anchor => {
  anchor.addEventListener('click', function(e) {
    e.preventDefault();
      document.querySelector(this.getAttribute('href')).scrollIntoView({
        behavior: 'smooth'
      });
  });
}); 

const ctx = document.getElementById('skillsRadarChart').getContext('2d');
const skillsRadarChart = new Chart(ctx, {
  type: 'radar',
  data: {
    labels: ['C#', 'CSS', 'HTML', 'Java', 'Javascript', 'Kotlin', 'MySQL', 'PHP', 'Python', 'React', 'TypeScript'],
    datasets: [{
      label: 'Skill Levels',
      data: [80, 85, 100, 50, 90, 20, 95, 60, 100, 50, 60],
      backgroundColor: 'rgba(54, 162, 235, 0.3)',
      borderColor: 'rgba(54, 162, 235, 1)',
      borderWidth: 3,
      pointBackgroundColor: 'rgba(255, 99, 132, 1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(255, 99, 132, 1)'
    }]
  },
  options: {
    responsive: true,
    plugins: {
      legend: {
        display: true,
        position: 'top',
        labels: {
          font: {
            size: 16,
            family: 'Arial, sans-serif',
            weight: 'bold'
          },
          color: '#444'
        }
      },
      tooltip: {
        backgroundColor: 'rgba(0, 0, 0, 0.7)',
        titleFont: {
          size: 14,
          weight: 'bold'
        },
        bodyFont: {
          size: 12
        },
        callbacks: {
          label: function(context) {
            return `${context.label}: ${context.raw}%`;
          }
        }
      }
    },
    scales: {
      r: {
        beginAtZero: true,
        suggestedMax: 100,
        grid: {
          color: 'rgba(150, 150, 150, 0.3)',
          circular: true
        },
        angleLines: {
          color: 'rgba(150, 150, 150, 0.5)'
        },
        ticks: {
          backdropColor: 'rgba(255, 255, 255, 0.9)',
          font: {
            size: 14,
            family: 'Courier New, monospace'
          },
          color: '#555'
        },
        pointLabels: {
          font: {
            size: 16,
            family: 'Verdana, sans-serif',
            weight: 'bold'
          },
          color: '#222'
        }
      }
    }
  }
});