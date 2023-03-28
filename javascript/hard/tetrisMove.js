let strArr = ["T","4","3","2","3","5","2","0","1","2","4","3","4"];
let sembols = [
  ["I", [[1, 1, 1, 1]]],
  ["J", [[1, 1, 1],[0, 0, 1]]],
  ["L", [[1, 1, 1],[1,0,0]]],
  ["O", [[1, 1],[1,1]]],
  ["S", [[0, 1, 1],[1,1,0]]],
  ["T", [[1, 1, 1],[0, 1, 0]]],
  ["Z", [[1, 1, 0],[0, 1, 1]]]
];
let boardRow=10;
let boardCol=12;
let total=0;
let board=[];
board=ReBoard(strArr);
RunBoard();
console.log(total);

// functions
function RunBoard() {
    for (let p = 0; p < sembols.length; p++) {
        if (strArr[0]==sembols[p][0]) {
            let rotated=MatRotate(sembols[p][1],sembols[p][1].length,sembols[p][1][0].length)
            for (let x = 0; x < 4; x++) {
                if (x!=0) {
                    rotated=MatRotate(rotated,rotated.length,rotated[0].length)
                }
                for (let m = 0; m <= boardRow-rotated.length; m++) {
                    MYLOOP:for (let n = 0; n <= boardCol-rotated[0].length; n++) {                        
                        for (let i = 0; i < rotated.length; i++) {
                            for (let j = 0; j < rotated[0].length; j++) {
                                if (board[m+i][n+j]==1 && rotated[i][j]==1) {
                                    continue MYLOOP
                                }
                                else if(board[m+i][n+j]==1 && rotated[i][j]==0){
                                }
                                else if(board[m+i][n+j]==0){
                                    board[m+i][n+j] = rotated[i][j];
                                }                    
                            }                           
                        }
                        if (LineCheck(boardRow,boardCol,board)!=0) {
                            let vl=LineCheck(boardRow,boardCol,board);
                            total=total<vl?vl:total;
                        }
                        board=ReBoard(strArr);
                                         
                    }                    
                }
            }
        }        
    }
}
function ReBoard(arr) {
    let reboard=[];
    for (let i = 0; i < boardRow; i++) {
        reboard.push([])
        for (let j = 0; j < boardCol; j++) {
            reboard[i][j]=0;        
        }        
    }
    for (let i = 0; i < boardCol; i++) {        
        for (let j = 0; j < arr[i+1].valueOf(); j++) {
            reboard[boardRow-1-j][i]=1;        
        }        
    }
    return reboard;
}
function MatRotate(matrix,row,col) {
    let rowln=matrix.length==row?col:row;
    let colln=matrix[0].length==row?col:row;
    let rotated=[];
    for (let i = 0; i < rowln; i++) {
        rotated.push([]);
        for (let j = 0; j < colln; j++) {
        rotated[i][j]=matrix[colln-1-j][i];        
        }        
    }
    return rotated;
}
function LineCheck(row,col,board) {
    let counter=0;
    let lineCounter=0;
    for (let i = 0; i < row; i++) {
        for (let j = 0; j < col; j++) {
            if (board[i][j]==1) {
                lineCounter++;
            }        
        }
        if (lineCounter==col) {
            counter++;
        }
        lineCounter=0;
    }
    return counter;
}

