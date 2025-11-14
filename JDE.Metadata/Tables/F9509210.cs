using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9509210 - .
/// </summary>
public class F9509210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDOBNM.
        /// </summary>
        public const string IDOBNM = "IDOBNM";

        /// <summary>
        /// IDCTRLID.
        /// </summary>
        public const string IDCTRLID = "IDCTRLID";

        /// <summary>
        /// IDRCRDTP.
        /// </summary>
        public const string IDRCRDTP = "IDRCRDTP";

        /// <summary>
        /// IDFMNM.
        /// </summary>
        public const string IDFMNM = "IDFMNM";

        /// <summary>
        /// IDTEXTID.
        /// </summary>
        public const string IDTEXTID = "IDTEXTID";

        /// <summary>
        /// IDTEXT1.
        /// </summary>
        public const string IDTEXT1 = "IDTEXT1";
    }

    /// <inheritdoc />
    public override string TableName => "F9509210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDOBNM", "IDOBNM", JdeDataType.String, 20, true, true),
        new JdeField("IDCTRLID", "IDCTRLID", JdeDataType.Numeric, null, true, true),
        new JdeField("IDRCRDTP", "IDRCRDTP", JdeDataType.Numeric, null, true, true),
        new JdeField("IDFMNM", "IDFMNM", JdeDataType.String, 20, true, true),
        new JdeField("IDTEXTID", "IDTEXTID", JdeDataType.Numeric, null, true, true),
        new JdeField("IDTEXT1", "IDTEXT1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9509210_0", "Primary Key on IDOBNM, IDCTRLID, IDRCRDTP, IDFMNM, IDTEXTID", new[] { "IDOBNM", "IDCTRLID", "IDRCRDTP", "IDFMNM", "IDTEXTID" }, isUnique: true, isPrimaryKey: true)
    };
}
