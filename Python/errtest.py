class MaxHeap:
    def __init__(self, maxsize):
        self.size = 0
        self.maxsize = maxsize              # to set maximum range of heap
        self.Heap = [0] * maxsize           # create array with maximum size

    def parent(self, pos: int) -> int:          # as the data structure , to find parent node
        return (pos) // 2

    def insert(self, ele):
        if self.size >= self.maxsize:       # return nothing is the maximum insertion exceeded
            return
        self.Heap[self.size] = ele          # insert element is heap array
        cur = self.size
        # check parent is less than or not
        while cur != 0 and self.Heap[cur] > self.Heap[self.parent(cur)]:
            self.swap(cur, self.parent(cur))     # if so , swap the value
            # set the parent value as the current to check upper parent
            cur = self.parent(cur)
        self.size += 1

    def swap(self, fv, sv):
        # swap two value
        self.Heap[fv], self.Heap[sv] = self.Heap[sv], self.Heap[fv]

    def heap(self):         # heap the array
        l = self.size // 2
        for i in range(l-1, -1, -1):  # not to heapify the leaf level
            self.heapify(i)

    def print(self):
        print(self.Heap)        # print the heap array

    def __str__(self):          # to check the size
        return f"You have inserted {self.size} places"

    def heapify(self, pos):      # heapify the array
        Lchild = (pos*2) + 1    # set left child
        Rchild = (pos*2) + 2    # set right chile
        if (pos*2) <= len(self.Heap):   # not to check the leaf node
            # if the child nodes
            if self.Heap[pos] < self.Heap[Lchild] or self.Heap[pos] < self.Heap[Rchild]:
                # are greater
                if self.Heap[pos] < self.Heap[Lchild]:
                    # swap
                    self.swap(pos, Lchild)
                    # recursive to the child
                    self.heapify(Lchild)
                elif self.Heap[pos] < self.Heap[Rchild]:
                    self.swap(pos, Rchild)
                    self.heapify(Rchild)


if __name__ == '__main__':
    heap = MaxHeap(7)
    lst = [2, 15, 4, 30, 18, 6, 25]
    for i in lst:
        heap.insert(i)
    heap.print()
    heap.heap()
    print(heap)
