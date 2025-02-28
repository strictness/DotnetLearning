﻿using Chapter1.Tests.Input;
using Chapter1.Tests.Input.Insert;
using Chapter1.Tests.Input.Remove;
using FluentAssertions;
using Homework5;
using static Chapter1.Tests.Input.Insert.InsertElementExpectations;

namespace Chapter1.Tests;

    // You don't have to be here for a long time.
    public class Homework5Tests
    {
        [Theory]
        [ClassData(typeof(ArraySortExpectations))]
        public void SortArray_Modifies_Original_ToBe_InAscendingOrder(int[] inputArray, int[] expectedArray)
        {
            ArrayOperations.Sort(inputArray);

            inputArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(ArrayReverseExpectations))]
        public void ReverseArray_ModifiesOriginal_ToBe_ReversedArray(int[] inputArray, int[] expectedArray)
        {
            ArrayOperations.Reverse(inputArray);

            inputArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(InsertElementAtExpectations))]
        public void InsertAt_Returns_Array_WithExpectedElements(int[] inputArray, int index, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.InsertAt(inputArray, ElementToBeInserted, index);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(InsertLastElementExpectations))]
        public void InsertLast_Returns_Array_With_ExpectedElements(int[] inputArray, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.InsertLast(inputArray, ElementToBeInserted);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(InsertFirstElementExpectations))]
        public void InsertFirst_Returns_Array_With_ExpectedElements(int[] inputArray, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.InsertFirst(inputArray, ElementToBeInserted);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(RemoveElementAtExpectations))]
        public void RemoveAt_Returns_Array_WithExpectedElements(int[] inputArray, int index, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.RemoveAt(inputArray, index);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(RemoveLastElementExpectations))]
        public void RemoveLast_Returns_Array_With_ExpectedElements(int[] inputArray, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.RemoveLast(inputArray);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }

        [Theory]
        [ClassData(typeof(RemoveFirstElementExpectations))]
        public void RemoveFirst_Returns_Array_With_ExpectedElements(int[] inputArray, int[] expectedArray)
        {
            var modifiedArray = ArrayOperations.RemoveFirst(inputArray);

            modifiedArray.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }
    }

