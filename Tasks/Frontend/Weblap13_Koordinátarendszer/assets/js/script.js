document.addEventListener('DOMContentLoaded', function () {
    const canvas = document.getElementById('koordinataRendszer');
    const ctx = canvas.getContext('2d');
  
    const offsetX = canvas.width / 2; 
    const offsetY = canvas.height / 2;
    const scale = 20;;
    
    let points = []; 
    let functionStr = ''; 
  
    function drawFunction() {
      ctx.clearRect(0, 0, canvas.width, canvas.height); 
  
      drawAxes();
  
      if (functionStr) {
        try {
          const fn = new Function('x', `return ${functionStr}`);
          ctx.beginPath();
          for (let x = -offsetX / scale; x <= offsetX / scale; x += 0.1) {
            const y = fn(x);
            ctx.lineTo(offsetX + x * scale, offsetY - y * scale);
          }
          ctx.strokeStyle = 'red';
          ctx.stroke();
        } catch (e) {
          alert('Érvénytelen függvény!');
        }
      }
  
      drawPoints();
    }
  
    function drawAxes() {
      ctx.beginPath();
      ctx.moveTo(0, offsetY);
      ctx.lineTo(canvas.width, offsetY); 
      ctx.moveTo(offsetX, 0);
      ctx.lineTo(offsetX, canvas.height); 
      ctx.strokeStyle = 'black';
      ctx.stroke();
    }
  
    function drawPoints() {
      ctx.fillStyle = 'blue';
      points.forEach(point => {
        const x = offsetX + point.x * scale;
        const y = offsetY - point.y * scale;
        ctx.beginPath();
        ctx.arc(x, y, 5, 0, Math.PI * 2); 
        ctx.fill();
      });
    }
  
    document.getElementById('pontHozzaad').addEventListener('click', function () {
      const x = parseFloat(document.getElementById('xErtek').value);
      const y = parseFloat(document.getElementById('yErtek').value);
      if (!isNaN(x) && !isNaN(y)) {
        points.push({ x, y });
        drawFunction();
      } else {
        alert('Kérlek, érvényes számokat adj meg!');
      }
    });
  
    document.getElementById('fuggvenyRajzol').addEventListener('click', function () {
      functionStr = document.getElementById('fuggvenyInput').value;
      drawFunction();
    });
  
    drawFunction();
  });
  