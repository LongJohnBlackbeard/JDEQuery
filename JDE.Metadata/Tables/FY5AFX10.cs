using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX10 - .
/// </summary>
public class FY5AFX10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDY5AFSTID.
        /// </summary>
        public const string PDY5AFSTID = "PDY5AFSTID";

        /// <summary>
        /// PDY5AFPRTY.
        /// </summary>
        public const string PDY5AFPRTY = "PDY5AFPRTY";

        /// <summary>
        /// PDY5AFPNME.
        /// </summary>
        public const string PDY5AFPNME = "PDY5AFPNME";

        /// <summary>
        /// PDSEQ.
        /// </summary>
        public const string PDSEQ = "PDSEQ";

        /// <summary>
        /// PDY5AFCNME.
        /// </summary>
        public const string PDY5AFCNME = "PDY5AFCNME";

        /// <summary>
        /// PDY5AFTYPE.
        /// </summary>
        public const string PDY5AFTYPE = "PDY5AFTYPE";

        /// <summary>
        /// PDY5AFCLVL.
        /// </summary>
        public const string PDY5AFCLVL = "PDY5AFCLVL";

        /// <summary>
        /// PDUSRALPH.
        /// </summary>
        public const string PDUSRALPH = "PDUSRALPH";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURC1.
        /// </summary>
        public const string PDURC1 = "PDURC1";

        /// <summary>
        /// PDCRTU.
        /// </summary>
        public const string PDCRTU = "PDCRTU";

        /// <summary>
        /// PDCADT.
        /// </summary>
        public const string PDCADT = "PDCADT";

        /// <summary>
        /// PDMUSE.
        /// </summary>
        public const string PDMUSE = "PDMUSE";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDY5AFSTID", "PDY5AFSTID", JdeDataType.String, 20, true, true),
        new JdeField("PDY5AFPRTY", "PDY5AFPRTY", JdeDataType.String, 2, true, true),
        new JdeField("PDY5AFPNME", "PDY5AFPNME", JdeDataType.String, 20, true, true),
        new JdeField("PDSEQ", "PDSEQ", JdeDataType.Numeric),
        new JdeField("PDY5AFCNME", "PDY5AFCNME", JdeDataType.String, 20, true, true),
        new JdeField("PDY5AFTYPE", "PDY5AFTYPE", JdeDataType.String, 2, true, true),
        new JdeField("PDY5AFCLVL", "PDY5AFCLVL", JdeDataType.String, 2),
        new JdeField("PDUSRALPH", "PDUSRALPH", JdeDataType.String, 60),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURC1", "PDURC1", JdeDataType.String, 6),
        new JdeField("PDCRTU", "PDCRTU", JdeDataType.String, 20),
        new JdeField("PDCADT", "PDCADT", JdeDataType.Numeric),
        new JdeField("PDMUSE", "PDMUSE", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX10_0", "Primary Key on PDY5AFSTID, PDY5AFPRTY, PDY5AFPNME, PDY5AFTYPE, PDY5AFCNME", new[] { "PDY5AFSTID", "PDY5AFPRTY", "PDY5AFPNME", "PDY5AFTYPE", "PDY5AFCNME" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FY5AFX10_2", "Index on PDY5AFSTID, PDY5AFCNME, PDY5AFPNME", new[] { "PDY5AFSTID", "PDY5AFCNME", "PDY5AFPNME" }),
        new JdeIndex("FY5AFX10_3", "Index on PDY5AFSTID, PDY5AFTYPE, PDY5AFCNME, PDY5AFPRTY, PDY5AFPNME", new[] { "PDY5AFSTID", "PDY5AFTYPE", "PDY5AFCNME", "PDY5AFPRTY", "PDY5AFPNME" })
    };
}
