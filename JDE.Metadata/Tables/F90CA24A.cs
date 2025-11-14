using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA24A - .
/// </summary>
public class F90CA24A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDTID.
        /// </summary>
        public const string DTDTID = "DTDTID";

        /// <summary>
        /// DTDTTNAME.
        /// </summary>
        public const string DTDTTNAME = "DTDTTNAME";

        /// <summary>
        /// DTDTDESC.
        /// </summary>
        public const string DTDTDESC = "DTDTDESC";

        /// <summary>
        /// DTDTTCFLG.
        /// </summary>
        public const string DTDTTCFLG = "DTDTTCFLG";

        /// <summary>
        /// DTDTAFLG.
        /// </summary>
        public const string DTDTAFLG = "DTDTAFLG";

        /// <summary>
        /// DTDTSUPDDT.
        /// </summary>
        public const string DTDTSUPDDT = "DTDTSUPDDT";

        /// <summary>
        /// DTDTACIND.
        /// </summary>
        public const string DTDTACIND = "DTDTACIND";

        /// <summary>
        /// DTCRTU.
        /// </summary>
        public const string DTCRTU = "DTCRTU";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA24A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDTID", "DTDTID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTDTTNAME", "DTDTTNAME", JdeDataType.String, 150),
        new JdeField("DTDTDESC", "DTDTDESC", JdeDataType.String, 3998),
        new JdeField("DTDTTCFLG", "DTDTTCFLG", JdeDataType.String, 2),
        new JdeField("DTDTAFLG", "DTDTAFLG", JdeDataType.String, 2),
        new JdeField("DTDTSUPDDT", "DTDTSUPDDT", JdeDataType.Numeric),
        new JdeField("DTDTACIND", "DTDTACIND", JdeDataType.String, 2),
        new JdeField("DTCRTU", "DTCRTU", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA24A_0", "Primary Key on DTDTID", new[] { "DTDTID" }, isUnique: true, isPrimaryKey: true)
    };
}
