using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0100 - .
/// </summary>
public class F74R0100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCR74PCID.
        /// </summary>
        public const string PCR74PCID = "PCR74PCID";

        /// <summary>
        /// PCKCO.
        /// </summary>
        public const string PCKCO = "PCKCO";

        /// <summary>
        /// PCR74DTCD.
        /// </summary>
        public const string PCR74DTCD = "PCR74DTCD";

        /// <summary>
        /// PCR74DOCD.
        /// </summary>
        public const string PCR74DOCD = "PCR74DOCD";

        /// <summary>
        /// PCR74DPCD.
        /// </summary>
        public const string PCR74DPCD = "PCR74DPCD";

        /// <summary>
        /// PCDCT.
        /// </summary>
        public const string PCDCT = "PCDCT";

        /// <summary>
        /// PCDOC.
        /// </summary>
        public const string PCDOC = "PCDOC";

        /// <summary>
        /// PCDGJ.
        /// </summary>
        public const string PCDGJ = "PCDGJ";

        /// <summary>
        /// PCJELN.
        /// </summary>
        public const string PCJELN = "PCJELN";

        /// <summary>
        /// PCLT.
        /// </summary>
        public const string PCLT = "PCLT";

        /// <summary>
        /// PCVOD.
        /// </summary>
        public const string PCVOD = "PCVOD";

        /// <summary>
        /// PCVDGJ.
        /// </summary>
        public const string PCVDGJ = "PCVDGJ";

        /// <summary>
        /// PCAID.
        /// </summary>
        public const string PCAID = "PCAID";

        /// <summary>
        /// PCICUT.
        /// </summary>
        public const string PCICUT = "PCICUT";

        /// <summary>
        /// PCICU.
        /// </summary>
        public const string PCICU = "PCICU";

        /// <summary>
        /// PCPYID.
        /// </summary>
        public const string PCPYID = "PCPYID";

        /// <summary>
        /// PCA201.
        /// </summary>
        public const string PCA201 = "PCA201";

        /// <summary>
        /// PCPAAP.
        /// </summary>
        public const string PCPAAP = "PCPAAP";

        /// <summary>
        /// PCCRCD.
        /// </summary>
        public const string PCCRCD = "PCCRCD";

        /// <summary>
        /// PCPOST.
        /// </summary>
        public const string PCPOST = "PCPOST";

        /// <summary>
        /// PCSY.
        /// </summary>
        public const string PCSY = "PCSY";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCR74PNAM.
        /// </summary>
        public const string PCR74PNAM = "PCR74PNAM";

        /// <summary>
        /// PCR74PDES.
        /// </summary>
        public const string PCR74PDES = "PCR74PDES";

        /// <summary>
        /// PCR74PVAT.
        /// </summary>
        public const string PCR74PVAT = "PCR74PVAT";

        /// <summary>
        /// PCR74PDE1.
        /// </summary>
        public const string PCR74PDE1 = "PCR74PDE1";

        /// <summary>
        /// PCR74PDE2.
        /// </summary>
        public const string PCR74PDE2 = "PCR74PDE2";

        /// <summary>
        /// PCR74PAT1.
        /// </summary>
        public const string PCR74PAT1 = "PCR74PAT1";

        /// <summary>
        /// PCR74PAT2.
        /// </summary>
        public const string PCR74PAT2 = "PCR74PAT2";

        /// <summary>
        /// PCR74PAT3.
        /// </summary>
        public const string PCR74PAT3 = "PCR74PAT3";

        /// <summary>
        /// PCR74PAT4.
        /// </summary>
        public const string PCR74PAT4 = "PCR74PAT4";

        /// <summary>
        /// PCN001.
        /// </summary>
        public const string PCN001 = "PCN001";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCR74PCID", "PCR74PCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCKCO", "PCKCO", JdeDataType.String, 10),
        new JdeField("PCR74DTCD", "PCR74DTCD", JdeDataType.String, 4),
        new JdeField("PCR74DOCD", "PCR74DOCD", JdeDataType.Numeric),
        new JdeField("PCR74DPCD", "PCR74DPCD", JdeDataType.Numeric),
        new JdeField("PCDCT", "PCDCT", JdeDataType.String, 4),
        new JdeField("PCDOC", "PCDOC", JdeDataType.Numeric),
        new JdeField("PCDGJ", "PCDGJ", JdeDataType.Numeric),
        new JdeField("PCJELN", "PCJELN", JdeDataType.Numeric),
        new JdeField("PCLT", "PCLT", JdeDataType.String, 4),
        new JdeField("PCVOD", "PCVOD", JdeDataType.String, 2),
        new JdeField("PCVDGJ", "PCVDGJ", JdeDataType.Numeric),
        new JdeField("PCAID", "PCAID", JdeDataType.String, 16),
        new JdeField("PCICUT", "PCICUT", JdeDataType.String, 4),
        new JdeField("PCICU", "PCICU", JdeDataType.Numeric),
        new JdeField("PCPYID", "PCPYID", JdeDataType.Numeric),
        new JdeField("PCA201", "PCA201", JdeDataType.String, 4),
        new JdeField("PCPAAP", "PCPAAP", JdeDataType.Numeric),
        new JdeField("PCCRCD", "PCCRCD", JdeDataType.String, 6),
        new JdeField("PCPOST", "PCPOST", JdeDataType.String, 2),
        new JdeField("PCSY", "PCSY", JdeDataType.String, 8),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric),
        new JdeField("PCR74PNAM", "PCR74PNAM", JdeDataType.String, 160),
        new JdeField("PCR74PDES", "PCR74PDES", JdeDataType.String, 160),
        new JdeField("PCR74PVAT", "PCR74PVAT", JdeDataType.String, 160),
        new JdeField("PCR74PDE1", "PCR74PDE1", JdeDataType.String, 160),
        new JdeField("PCR74PDE2", "PCR74PDE2", JdeDataType.String, 160),
        new JdeField("PCR74PAT1", "PCR74PAT1", JdeDataType.String, 160),
        new JdeField("PCR74PAT2", "PCR74PAT2", JdeDataType.String, 160),
        new JdeField("PCR74PAT3", "PCR74PAT3", JdeDataType.String, 160),
        new JdeField("PCR74PAT4", "PCR74PAT4", JdeDataType.String, 160),
        new JdeField("PCN001", "PCN001", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0100_0", "Primary Key on PCR74PCID", new[] { "PCR74PCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R0100_2", "Index on PCKCO, PCDCT, PCDOC, PCDGJ, PCJELN, PCLT, PCVOD", new[] { "PCKCO", "PCDCT", "PCDOC", "PCDGJ", "PCJELN", "PCLT", "PCVOD" }),
        new JdeIndex("F74R0100_3", "Index on PCPYID, PCA201", new[] { "PCPYID", "PCA201" })
    };
}
