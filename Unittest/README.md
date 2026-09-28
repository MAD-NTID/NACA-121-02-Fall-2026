# What's So Special About Arrays in C#?

- An array holds an **ordered, fixed-size collection of values or objects of the same defined type**.

Consider the following statement:

> "An array holds an unordered, immutable list of variables."

### What's right or wrong about the statement above?

- **Unordered** — No. An array is **ordered by index**.
  - Each element has a specific index position.
  - The first element is at index `0`, the second at index `1`, and so on.

- **Immutable** — No. An array is **mutable** because the elements stored at its indexes can be changed.
  - What cannot be changed is the **size (length) of the array**.
  - Once an array is created with a specific length, that array cannot grow or shrink.

- **List of variables** — Not quite. An array is a **collection of elements (values or object references)**.
  - Each element is stored at a specific index.

- An array holds elements of a **defined type**.

```csharp
string[] names;
int[] numbers;
Character[] characters;
```

For example, an `int[]` holds `int` values, while a `Character[]` holds references to `Character` objects.

## Immutability

**Immutability** means that an object's state cannot be modified after the object is created.

An array is **not immutable**. Its elements can be changed:

```csharp
int[] numbers = { 10, 20, 30 };

numbers[0] = 50;
```

However, the array's **length is fixed** after the array is created.

# Array vs. ArrayList Concept

### Array

- Has a fixed length.
- Cannot grow or shrink after creation.
- Holds elements of a defined type.

### ArrayList / Resizable Array Concept

A resizable array can **appear to grow and shrink** by implementing behavior around an underlying array.

This does **not change the nature of an array**. The underlying array still has a fixed length.

For example, suppose an array is full and does not have any remaining indexes for another item.

**How could we circumvent this limitation and still add another item?**

1. Create a **new, larger array**.
2. Copy the elements from the old array into the new array at their corresponding indexes.
3. Add the new item to the next available index.
4. Use the new array in place of the old array.

For example:

```text
Original Array
[ A ][ B ][ C ]
  0    1    2

Create a Larger Array
[   ][   ][   ][   ]
  0    1    2    3

Copy Existing Elements
[ A ][ B ][ C ][   ]
  0    1    2    3

Add New Element
[ A ][ B ][ C ][ D ]
  0    1    2    3
```

The original array did not actually grow. Instead, a **new array with a larger capacity was created**, and the elements were copied into it.