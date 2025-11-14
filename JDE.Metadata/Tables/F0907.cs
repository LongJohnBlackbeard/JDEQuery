using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0907 - .
/// </summary>
public class F0907 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GYRETY.
        /// </summary>
        public const string GYRETY = "GYRETY";

        /// <summary>
        /// GYSBTY.
        /// </summary>
        public const string GYSBTY = "GYSBTY";

        /// <summary>
        /// GYEL.
        /// </summary>
        public const string GYEL = "GYEL";

        /// <summary>
        /// GYDL01.
        /// </summary>
        public const string GYDL01 = "GYDL01";

        /// <summary>
        /// GYELL.
        /// </summary>
        public const string GYELL = "GYELL";

        /// <summary>
        /// GYFLG1.
        /// </summary>
        public const string GYFLG1 = "GYFLG1";

        /// <summary>
        /// GYELTY.
        /// </summary>
        public const string GYELTY = "GYELTY";

        /// <summary>
        /// GYLR.
        /// </summary>
        public const string GYLR = "GYLR";

        /// <summary>
        /// GYSY.
        /// </summary>
        public const string GYSY = "GYSY";

        /// <summary>
        /// GYRT.
        /// </summary>
        public const string GYRT = "GYRT";

        /// <summary>
        /// GYDTAI.
        /// </summary>
        public const string GYDTAI = "GYDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F0907";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GYRETY", "GYRETY", JdeDataType.Numeric, null, true, true),
        new JdeField("GYSBTY", "GYSBTY", JdeDataType.Numeric, null, true, true),
        new JdeField("GYEL", "GYEL", JdeDataType.Numeric, null, true, true),
        new JdeField("GYDL01", "GYDL01", JdeDataType.String, 60),
        new JdeField("GYELL", "GYELL", JdeDataType.Numeric),
        new JdeField("GYFLG1", "GYFLG1", JdeDataType.String, 2),
        new JdeField("GYELTY", "GYELTY", JdeDataType.String, 2),
        new JdeField("GYLR", "GYLR", JdeDataType.String, 2),
        new JdeField("GYSY", "GYSY", JdeDataType.String, 8),
        new JdeField("GYRT", "GYRT", JdeDataType.String, 4),
        new JdeField("GYDTAI", "GYDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0907_0", "Primary Key on GYRETY, GYSBTY, GYEL", new[] { "GYRETY", "GYSBTY", "GYEL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0907_2", "Unique Index on GYRETY, GYEL, GYSBTY", new[] { "GYRETY", "GYEL", "GYSBTY" }, isUnique: true)
    };
}
