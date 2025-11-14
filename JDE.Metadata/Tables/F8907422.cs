using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8907422 - .
/// </summary>
public class F8907422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAMATH01.
        /// </summary>
        public const string MAMATH01 = "MAMATH01";

        /// <summary>
        /// MAEV01.
        /// </summary>
        public const string MAEV01 = "MAEV01";

        /// <summary>
        /// MATAXX.
        /// </summary>
        public const string MATAXX = "MATAXX";

        /// <summary>
        /// MAALPH.
        /// </summary>
        public const string MAALPH = "MAALPH";

        /// <summary>
        /// MAADD1.
        /// </summary>
        public const string MAADD1 = "MAADD1";

        /// <summary>
        /// MACTY1.
        /// </summary>
        public const string MACTY1 = "MACTY1";

        /// <summary>
        /// MAADDS.
        /// </summary>
        public const string MAADDS = "MAADDS";

        /// <summary>
        /// MAADDZ.
        /// </summary>
        public const string MAADDZ = "MAADDZ";

        /// <summary>
        /// MADL01.
        /// </summary>
        public const string MADL01 = "MADL01";

        /// <summary>
        /// MAMATH02.
        /// </summary>
        public const string MAMATH02 = "MAMATH02";

        /// <summary>
        /// MAEV02.
        /// </summary>
        public const string MAEV02 = "MAEV02";

        /// <summary>
        /// MASSN.
        /// </summary>
        public const string MASSN = "MASSN";

        /// <summary>
        /// MAALPH1.
        /// </summary>
        public const string MAALPH1 = "MAALPH1";

        /// <summary>
        /// MAADD2.
        /// </summary>
        public const string MAADD2 = "MAADD2";

        /// <summary>
        /// MAMSCY.
        /// </summary>
        public const string MAMSCY = "MAMSCY";

        /// <summary>
        /// MASTCD.
        /// </summary>
        public const string MASTCD = "MASTCD";

        /// <summary>
        /// MAADDO.
        /// </summary>
        public const string MAADDO = "MAADDO";

        /// <summary>
        /// MADL02.
        /// </summary>
        public const string MADL02 = "MADL02";
    }

    /// <inheritdoc />
    public override string TableName => "F8907422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAMATH01", "MAMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("MAEV01", "MAEV01", JdeDataType.String, 2),
        new JdeField("MATAXX", "MATAXX", JdeDataType.String, 40),
        new JdeField("MAALPH", "MAALPH", JdeDataType.String, 80),
        new JdeField("MAADD1", "MAADD1", JdeDataType.String, 80),
        new JdeField("MACTY1", "MACTY1", JdeDataType.String, 50),
        new JdeField("MAADDS", "MAADDS", JdeDataType.String, 6),
        new JdeField("MAADDZ", "MAADDZ", JdeDataType.String, 24),
        new JdeField("MADL01", "MADL01", JdeDataType.String, 60),
        new JdeField("MAMATH02", "MAMATH02", JdeDataType.Numeric),
        new JdeField("MAEV02", "MAEV02", JdeDataType.String, 2),
        new JdeField("MASSN", "MASSN", JdeDataType.String, 40),
        new JdeField("MAALPH1", "MAALPH1", JdeDataType.String, 80),
        new JdeField("MAADD2", "MAADD2", JdeDataType.String, 80),
        new JdeField("MAMSCY", "MAMSCY", JdeDataType.String, 50),
        new JdeField("MASTCD", "MASTCD", JdeDataType.String, 6),
        new JdeField("MAADDO", "MAADDO", JdeDataType.String, 24),
        new JdeField("MADL02", "MADL02", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8907422_0", "Primary Key on MAMATH01", new[] { "MAMATH01" }, isUnique: true, isPrimaryKey: true)
    };
}
