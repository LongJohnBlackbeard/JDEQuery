using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3303 - .
/// </summary>
public class F3303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTMCU.
        /// </summary>
        public const string CTMCU = "CTMCU";

        /// <summary>
        /// CTITM.
        /// </summary>
        public const string CTITM = "CTITM";

        /// <summary>
        /// CTLITM.
        /// </summary>
        public const string CTLITM = "CTLITM";

        /// <summary>
        /// CTAITM.
        /// </summary>
        public const string CTAITM = "CTAITM";

        /// <summary>
        /// CTMMCU.
        /// </summary>
        public const string CTMMCU = "CTMMCU";

        /// <summary>
        /// CTUNTY.
        /// </summary>
        public const string CTUNTY = "CTUNTY";

        /// <summary>
        /// CTUORG.
        /// </summary>
        public const string CTUORG = "CTUORG";

        /// <summary>
        /// CTTIMB.
        /// </summary>
        public const string CTTIMB = "CTTIMB";

        /// <summary>
        /// CTUM.
        /// </summary>
        public const string CTUM = "CTUM";

        /// <summary>
        /// CTTRKS.
        /// </summary>
        public const string CTTRKS = "CTTRKS";

        /// <summary>
        /// CTEFFF.
        /// </summary>
        public const string CTEFFF = "CTEFFF";

        /// <summary>
        /// CTEFFT.
        /// </summary>
        public const string CTEFFT = "CTEFFT";

        /// <summary>
        /// CTUKID.
        /// </summary>
        public const string CTUKID = "CTUKID";

        /// <summary>
        /// CTWMCU.
        /// </summary>
        public const string CTWMCU = "CTWMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F3303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTMCU", "CTMCU", JdeDataType.String, 24),
        new JdeField("CTITM", "CTITM", JdeDataType.Numeric),
        new JdeField("CTLITM", "CTLITM", JdeDataType.String, 50),
        new JdeField("CTAITM", "CTAITM", JdeDataType.String, 50),
        new JdeField("CTMMCU", "CTMMCU", JdeDataType.String, 24),
        new JdeField("CTUNTY", "CTUNTY", JdeDataType.String, 2),
        new JdeField("CTUORG", "CTUORG", JdeDataType.Numeric),
        new JdeField("CTTIMB", "CTTIMB", JdeDataType.String, 2),
        new JdeField("CTUM", "CTUM", JdeDataType.String, 4),
        new JdeField("CTTRKS", "CTTRKS", JdeDataType.Numeric),
        new JdeField("CTEFFF", "CTEFFF", JdeDataType.Numeric),
        new JdeField("CTEFFT", "CTEFFT", JdeDataType.Numeric),
        new JdeField("CTUKID", "CTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTWMCU", "CTWMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3303_0", "Primary Key on CTUKID", new[] { "CTUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3303_2", "Index on CTITM, CTMMCU, CTMCU, CTWMCU, CTUM, CTUNTY, CTEFFF, CTEFFT, CTTIMB", new[] { "CTITM", "CTMMCU", "CTMCU", "CTWMCU", "CTUM", "CTUNTY", "CTEFFF", "CTEFFT", "CTTIMB" }),
        new JdeIndex("F3303_3", "Index on CTMMCU, CTMCU, CTWMCU, CTUM, CTITM", new[] { "CTMMCU", "CTMCU", "CTWMCU", "CTUM", "CTITM" })
    };
}
