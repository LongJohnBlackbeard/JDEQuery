using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K51 - .
/// </summary>
public class FF31K51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFFSCID.
        /// </summary>
        public const string RFFSCID = "RFFSCID";

        /// <summary>
        /// RFDFMCU.
        /// </summary>
        public const string RFDFMCU = "RFDFMCU";

        /// <summary>
        /// RFDFRFQ.
        /// </summary>
        public const string RFDFRFQ = "RFDFRFQ";

        /// <summary>
        /// RFTLPRC.
        /// </summary>
        public const string RFTLPRC = "RFTLPRC";

        /// <summary>
        /// RFURCD.
        /// </summary>
        public const string RFURCD = "RFURCD";

        /// <summary>
        /// RFURDT.
        /// </summary>
        public const string RFURDT = "RFURDT";

        /// <summary>
        /// RFURAT.
        /// </summary>
        public const string RFURAT = "RFURAT";

        /// <summary>
        /// RFURAB.
        /// </summary>
        public const string RFURAB = "RFURAB";

        /// <summary>
        /// RFURRF.
        /// </summary>
        public const string RFURRF = "RFURRF";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFTORG.
        /// </summary>
        public const string RFTORG = "RFTORG";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFJOBN.
        /// </summary>
        public const string RFJOBN = "RFJOBN";

        /// <summary>
        /// RFUUPMJ.
        /// </summary>
        public const string RFUUPMJ = "RFUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFFSCID", "RFFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RFDFMCU", "RFDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("RFDFRFQ", "RFDFRFQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RFTLPRC", "RFTLPRC", JdeDataType.Numeric),
        new JdeField("RFURCD", "RFURCD", JdeDataType.String, 4),
        new JdeField("RFURDT", "RFURDT", JdeDataType.Numeric),
        new JdeField("RFURAT", "RFURAT", JdeDataType.Numeric),
        new JdeField("RFURAB", "RFURAB", JdeDataType.Numeric),
        new JdeField("RFURRF", "RFURRF", JdeDataType.String, 30),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFTORG", "RFTORG", JdeDataType.String, 20),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFJOBN", "RFJOBN", JdeDataType.String, 20),
        new JdeField("RFUUPMJ", "RFUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K51_0", "Primary Key on RFFSCID, RFDFMCU, RFDFRFQ", new[] { "RFFSCID", "RFDFMCU", "RFDFRFQ" }, isUnique: true, isPrimaryKey: true)
    };
}
