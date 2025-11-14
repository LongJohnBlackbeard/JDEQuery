using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3705 - .
/// </summary>
public class F3705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSCUKID.
        /// </summary>
        public const string SCSCUKID = "SCSCUKID";

        /// <summary>
        /// SCSMPCNTR.
        /// </summary>
        public const string SCSMPCNTR = "SCSMPCNTR";

        /// <summary>
        /// SCDESC.
        /// </summary>
        public const string SCDESC = "SCDESC";

        /// <summary>
        /// SCQUM.
        /// </summary>
        public const string SCQUM = "SCQUM";

        /// <summary>
        /// SCSMPCAP.
        /// </summary>
        public const string SCSMPCAP = "SCSMPCAP";

        /// <summary>
        /// SCSMPCLSR.
        /// </summary>
        public const string SCSMPCLSR = "SCSMPCLSR";

        /// <summary>
        /// SCQMDT1.
        /// </summary>
        public const string SCQMDT1 = "SCQMDT1";

        /// <summary>
        /// SCQMNUM1.
        /// </summary>
        public const string SCQMNUM1 = "SCQMNUM1";

        /// <summary>
        /// SCQMAB1.
        /// </summary>
        public const string SCQMAB1 = "SCQMAB1";

        /// <summary>
        /// SCQMCD1.
        /// </summary>
        public const string SCQMCD1 = "SCQMCD1";

        /// <summary>
        /// SCQMRF1.
        /// </summary>
        public const string SCQMRF1 = "SCQMRF1";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F3705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSCUKID", "SCSCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSMPCNTR", "SCSMPCNTR", JdeDataType.String, 20),
        new JdeField("SCDESC", "SCDESC", JdeDataType.String, 60),
        new JdeField("SCQUM", "SCQUM", JdeDataType.String, 6),
        new JdeField("SCSMPCAP", "SCSMPCAP", JdeDataType.Numeric),
        new JdeField("SCSMPCLSR", "SCSMPCLSR", JdeDataType.String, 20),
        new JdeField("SCQMDT1", "SCQMDT1", JdeDataType.Numeric),
        new JdeField("SCQMNUM1", "SCQMNUM1", JdeDataType.Numeric),
        new JdeField("SCQMAB1", "SCQMAB1", JdeDataType.Numeric),
        new JdeField("SCQMCD1", "SCQMCD1", JdeDataType.String, 6),
        new JdeField("SCQMRF1", "SCQMRF1", JdeDataType.String, 60),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3705_0", "Primary Key on SCSCUKID", new[] { "SCSCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3705_2", "Unique Index on SCSMPCNTR", new[] { "SCSMPCNTR" }, isUnique: true)
    };
}
