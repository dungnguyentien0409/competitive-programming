/*
 * Problem: QuickSort List
 * Author: Dung Nguyen Tien (Chris)
*/

function quickSort(head, tail){
    if (head == tail) return;
    
    var slow = partition(head, tail);
    quickSort(head, slow);
    quickSort(slow.next, tail);
}

function partition(head, tail) {
    var i = head;
    var pivot = i.val;
    
    for (var node = head.next; node != tail; node = node.next) {
        if (node.val < pivot) {
            i = i.next;
            swap(i, node);
        }
    }
    
    swap(i, head);
    
    return i;
}

function swap(node1, node2){
     var tmp = node1.val;
     node1.val = node2.val;
     node2.val = tmp;
}