//
// This is only a SKELETON file for the 'Linked List' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

class Node {
  constructor(value, previous = null, next = null) {
    this.value = value;
    this.previous = previous;
    this.next = next;
  }
}

export class LinkedList {
  constructor() {
    this.head = this.tail = null;
    this.nodeCount = 0;
  }

  push(value) {
    this.nodeCount++;
    if (this.tail === null) {
      this.tail = this.head = new Node(value);
    } else {
      this.tail = this.tail.next = new Node(value, this.tail);
    }
  }

  pop() {
    this.nodeCount--;
    const value = this.tail.value;
    this.tail = this.tail.previous;
    if (this.tail) {
      this.tail.next = null;
    } else {
      this.head = null;
    }
    return value;
  }

  shift() {
    this.nodeCount--;
    const value = this.head.value;
    this.head = this.head.next;
    if (this.head) {
      this.head.prevous = null;
    } else {
      this.tail = null;
    }
    return value;
  }

  unshift(value) {
    this.nodeCount++;
    if (this.head === null) {
      this.head = this.tail = new Node(value);
    } else {
      this.head = this.head.previous = new Node(value, null, this.head);
    }
  }

  delete(value) {
    if (this.head.value === value) {
      this.shift();
    } else {
      let current = this.head;
      while (current.next != null && current.next.value != value) {
        current = current.next;
      }
      if (current.next === null) return;
      this.nodeCount--;
      if (current.next.next === null) this.tail = current;
      current.next = current.next.next;
      if (current.next != null) current.next.previous = current;
    }
  }

  count() {
    return this.nodeCount;
  }
}
