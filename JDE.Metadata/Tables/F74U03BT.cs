using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U03BT - .
/// </summary>
public class F74U03BT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFLNID.
        /// </summary>
        public const string PFLNID = "PFLNID";

        /// <summary>
        /// PFDOCO.
        /// </summary>
        public const string PFDOCO = "PFDOCO";

        /// <summary>
        /// PFLSVR.
        /// </summary>
        public const string PFLSVR = "PFLSVR";

        /// <summary>
        /// PFMCU.
        /// </summary>
        public const string PFMCU = "PFMCU";

        /// <summary>
        /// PFUNIT.
        /// </summary>
        public const string PFUNIT = "PFUNIT";

        /// <summary>
        /// PFUM.
        /// </summary>
        public const string PFUM = "PFUM";

        /// <summary>
        /// PF74UAUOM.
        /// </summary>
        public const string PF74UAUOM = "PF74UAUOM";

        /// <summary>
        /// PFPMU1.
        /// </summary>
        public const string PFPMU1 = "PFPMU1";

        /// <summary>
        /// PFARTY.
        /// </summary>
        public const string PFARTY = "PFARTY";

        /// <summary>
        /// PFDL01.
        /// </summary>
        public const string PFDL01 = "PFDL01";

        /// <summary>
        /// PFSEQ.
        /// </summary>
        public const string PFSEQ = "PFSEQ";

        /// <summary>
        /// PFEV01.
        /// </summary>
        public const string PFEV01 = "PFEV01";

        /// <summary>
        /// PFURRF.
        /// </summary>
        public const string PFURRF = "PFURRF";

        /// <summary>
        /// PFURAB.
        /// </summary>
        public const string PFURAB = "PFURAB";

        /// <summary>
        /// PFURCD.
        /// </summary>
        public const string PFURCD = "PFURCD";

        /// <summary>
        /// PFURAT.
        /// </summary>
        public const string PFURAT = "PFURAT";

        /// <summary>
        /// PFURDT.
        /// </summary>
        public const string PFURDT = "PFURDT";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U03BT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFLNID", "PFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFDOCO", "PFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PFLSVR", "PFLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("PFMCU", "PFMCU", JdeDataType.String, 24, true, true),
        new JdeField("PFUNIT", "PFUNIT", JdeDataType.String, 16, true, true),
        new JdeField("PFUM", "PFUM", JdeDataType.String, 4),
        new JdeField("PF74UAUOM", "PF74UAUOM", JdeDataType.String, 4),
        new JdeField("PFPMU1", "PFPMU1", JdeDataType.Numeric),
        new JdeField("PFARTY", "PFARTY", JdeDataType.String, 6),
        new JdeField("PFDL01", "PFDL01", JdeDataType.String, 60),
        new JdeField("PFSEQ", "PFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PFEV01", "PFEV01", JdeDataType.String, 2),
        new JdeField("PFURRF", "PFURRF", JdeDataType.String, 30),
        new JdeField("PFURAB", "PFURAB", JdeDataType.Numeric),
        new JdeField("PFURCD", "PFURCD", JdeDataType.String, 4),
        new JdeField("PFURAT", "PFURAT", JdeDataType.Numeric),
        new JdeField("PFURDT", "PFURDT", JdeDataType.Numeric),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U03BT_0", "Primary Key on PFDOCO, PFLSVR, PFMCU, PFUNIT, PFSEQ, PFLNID", new[] { "PFDOCO", "PFLSVR", "PFMCU", "PFUNIT", "PFSEQ", "PFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
