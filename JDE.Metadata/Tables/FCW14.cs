using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW14 - .
/// </summary>
public class FCW14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTITM.
        /// </summary>
        public const string WTITM = "WTITM";

        /// <summary>
        /// WTEV01.
        /// </summary>
        public const string WTEV01 = "WTEV01";

        /// <summary>
        /// WTMCU.
        /// </summary>
        public const string WTMCU = "WTMCU";

        /// <summary>
        /// WTUPCN.
        /// </summary>
        public const string WTUPCN = "WTUPCN";

        /// <summary>
        /// WTSCC0.
        /// </summary>
        public const string WTSCC0 = "WTSCC0";

        /// <summary>
        /// WTUMUP.
        /// </summary>
        public const string WTUMUP = "WTUMUP";

        /// <summary>
        /// WTUMDF.
        /// </summary>
        public const string WTUMDF = "WTUMDF";

        /// <summary>
        /// WTUMS0.
        /// </summary>
        public const string WTUMS0 = "WTUMS0";

        /// <summary>
        /// WTUMS1.
        /// </summary>
        public const string WTUMS1 = "WTUMS1";

        /// <summary>
        /// WTUMS2.
        /// </summary>
        public const string WTUMS2 = "WTUMS2";

        /// <summary>
        /// WTUMS3.
        /// </summary>
        public const string WTUMS3 = "WTUMS3";

        /// <summary>
        /// WTUMS4.
        /// </summary>
        public const string WTUMS4 = "WTUMS4";

        /// <summary>
        /// WTUMS5.
        /// </summary>
        public const string WTUMS5 = "WTUMS5";

        /// <summary>
        /// WTUMS6.
        /// </summary>
        public const string WTUMS6 = "WTUMS6";

        /// <summary>
        /// WTUMS7.
        /// </summary>
        public const string WTUMS7 = "WTUMS7";

        /// <summary>
        /// WTUMS8.
        /// </summary>
        public const string WTUMS8 = "WTUMS8";

        /// <summary>
        /// WTPOC.
        /// </summary>
        public const string WTPOC = "WTPOC";

        /// <summary>
        /// WTAVRT.
        /// </summary>
        public const string WTAVRT = "WTAVRT";

        /// <summary>
        /// WTEQTY.
        /// </summary>
        public const string WTEQTY = "WTEQTY";

        /// <summary>
        /// WTWTRQ.
        /// </summary>
        public const string WTWTRQ = "WTWTRQ";
    }

    /// <inheritdoc />
    public override string TableName => "FCW14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTITM", "WTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WTEV01", "WTEV01", JdeDataType.String, 2, true, true),
        new JdeField("WTMCU", "WTMCU", JdeDataType.String, 24, true, true),
        new JdeField("WTUPCN", "WTUPCN", JdeDataType.String, 26),
        new JdeField("WTSCC0", "WTSCC0", JdeDataType.String, 28),
        new JdeField("WTUMUP", "WTUMUP", JdeDataType.String, 4),
        new JdeField("WTUMDF", "WTUMDF", JdeDataType.String, 4),
        new JdeField("WTUMS0", "WTUMS0", JdeDataType.String, 4),
        new JdeField("WTUMS1", "WTUMS1", JdeDataType.String, 4),
        new JdeField("WTUMS2", "WTUMS2", JdeDataType.String, 4),
        new JdeField("WTUMS3", "WTUMS3", JdeDataType.String, 4),
        new JdeField("WTUMS4", "WTUMS4", JdeDataType.String, 4),
        new JdeField("WTUMS5", "WTUMS5", JdeDataType.String, 4),
        new JdeField("WTUMS6", "WTUMS6", JdeDataType.String, 4),
        new JdeField("WTUMS7", "WTUMS7", JdeDataType.String, 4),
        new JdeField("WTUMS8", "WTUMS8", JdeDataType.String, 4),
        new JdeField("WTPOC", "WTPOC", JdeDataType.String, 2),
        new JdeField("WTAVRT", "WTAVRT", JdeDataType.Numeric),
        new JdeField("WTEQTY", "WTEQTY", JdeDataType.String, 10),
        new JdeField("WTWTRQ", "WTWTRQ", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW14_0", "Primary Key on WTITM, WTEV01, WTMCU", new[] { "WTITM", "WTEV01", "WTMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
