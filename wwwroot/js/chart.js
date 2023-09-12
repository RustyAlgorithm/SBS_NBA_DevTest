// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// chart.js

// Get the canvas element
const ctx = document.getElementById('nbaChart').getContext('2d');

// Initialize a default chart (e.g., "Won" column)
let chart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: [],  // Fill this with team names
        datasets: [{
            label: 'Won',
            data: [],  // Fill this with "Won" data
            backgroundColor: 'rgba(75, 192, 192, 0.2)',  // Adjust color as needed
            borderColor: 'rgba(75, 192, 192, 1)',  // Adjust color as needed
            borderWidth: 1
        }]
    },
    options: {
        responsive: true,
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

// Function to update the chart data
function updateChart(data, label) {
    chart.data.labels = data.labels;
    chart.data.datasets[0].data = data.values;
    chart.data.datasets[0].label = label;
    chart.update();
}

// Function to fetch "Lost" data from the server
function fetchLostDataAndRenderChart() {
    // Make an AJAX request to your server to get the "Lost" data
    fetch('/api/lostData')
        .then(response => response.json())
        .then(data => {
            // Update the chart with the fetched "Lost" data
            updateChart(data, 'Lost');
        })
        .catch(error => console.error('Error fetching data:', error));
}


// Add an event listener to the "Lost" column header
document.getElementById('lostColumnHeader').addEventListener('click', function () {
        // Add an event listener to the "Lost" column header
    document.getElementById('lostColumnHeader').addEventListener('click', function () {
        // Fetch "Lost" data from the server and update the chart
        fetchLostDataAndRenderChart();
    });

    updateChart(lostData, 'Lost');
});
