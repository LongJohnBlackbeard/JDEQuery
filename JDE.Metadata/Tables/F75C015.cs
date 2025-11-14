using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C015 - .
/// </summary>
public class F75C015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFKCO.
        /// </summary>
        public const string CFKCO = "CFKCO";

        /// <summary>
        /// CFDCT.
        /// </summary>
        public const string CFDCT = "CFDCT";

        /// <summary>
        /// CFDOC.
        /// </summary>
        public const string CFDOC = "CFDOC";

        /// <summary>
        /// CFDGJ.
        /// </summary>
        public const string CFDGJ = "CFDGJ";

        /// <summary>
        /// CFJELN.
        /// </summary>
        public const string CFJELN = "CFJELN";

        /// <summary>
        /// CFEXTL.
        /// </summary>
        public const string CFEXTL = "CFEXTL";

        /// <summary>
        /// CFCO.
        /// </summary>
        public const string CFCO = "CFCO";

        /// <summary>
        /// CFC75SEQN.
        /// </summary>
        public const string CFC75SEQN = "CFC75SEQN";

        /// <summary>
        /// CFPOST.
        /// </summary>
        public const string CFPOST = "CFPOST";

        /// <summary>
        /// CFICU.
        /// </summary>
        public const string CFICU = "CFICU";

        /// <summary>
        /// CFICUT.
        /// </summary>
        public const string CFICUT = "CFICUT";

        /// <summary>
        /// CFAID.
        /// </summary>
        public const string CFAID = "CFAID";

        /// <summary>
        /// CFANI.
        /// </summary>
        public const string CFANI = "CFANI";

        /// <summary>
        /// CFMCU.
        /// </summary>
        public const string CFMCU = "CFMCU";

        /// <summary>
        /// CFOBJ.
        /// </summary>
        public const string CFOBJ = "CFOBJ";

        /// <summary>
        /// CFSUB.
        /// </summary>
        public const string CFSUB = "CFSUB";

        /// <summary>
        /// CFPN.
        /// </summary>
        public const string CFPN = "CFPN";

        /// <summary>
        /// CFCTRY.
        /// </summary>
        public const string CFCTRY = "CFCTRY";

        /// <summary>
        /// CFFY.
        /// </summary>
        public const string CFFY = "CFFY";

        /// <summary>
        /// CFSBL.
        /// </summary>
        public const string CFSBL = "CFSBL";

        /// <summary>
        /// CFSBLT.
        /// </summary>
        public const string CFSBLT = "CFSBLT";

        /// <summary>
        /// CFLT.
        /// </summary>
        public const string CFLT = "CFLT";

        /// <summary>
        /// CFVR01.
        /// </summary>
        public const string CFVR01 = "CFVR01";

        /// <summary>
        /// CFAA.
        /// </summary>
        public const string CFAA = "CFAA";

        /// <summary>
        /// CFCRCD.
        /// </summary>
        public const string CFCRCD = "CFCRCD";

        /// <summary>
        /// CFACR.
        /// </summary>
        public const string CFACR = "CFACR";

        /// <summary>
        /// CFRE.
        /// </summary>
        public const string CFRE = "CFRE";

        /// <summary>
        /// CFFUTMATH1.
        /// </summary>
        public const string CFFUTMATH1 = "CFFUTMATH1";

        /// <summary>
        /// CFFUTSTR1.
        /// </summary>
        public const string CFFUTSTR1 = "CFFUTSTR1";

        /// <summary>
        /// CFFUTDATE1.
        /// </summary>
        public const string CFFUTDATE1 = "CFFUTDATE1";

        /// <summary>
        /// CFFUTUO1.
        /// </summary>
        public const string CFFUTUO1 = "CFFUTUO1";

        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFUPMT.
        /// </summary>
        public const string CFUPMT = "CFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFKCO", "CFKCO", JdeDataType.String, 10, true, true),
        new JdeField("CFDCT", "CFDCT", JdeDataType.String, 4, true, true),
        new JdeField("CFDOC", "CFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CFDGJ", "CFDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CFJELN", "CFJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("CFEXTL", "CFEXTL", JdeDataType.String, 4, true, true),
        new JdeField("CFCO", "CFCO", JdeDataType.String, 10),
        new JdeField("CFC75SEQN", "CFC75SEQN", JdeDataType.Numeric),
        new JdeField("CFPOST", "CFPOST", JdeDataType.String, 2),
        new JdeField("CFICU", "CFICU", JdeDataType.Numeric),
        new JdeField("CFICUT", "CFICUT", JdeDataType.String, 4),
        new JdeField("CFAID", "CFAID", JdeDataType.String, 16),
        new JdeField("CFANI", "CFANI", JdeDataType.String, 58),
        new JdeField("CFMCU", "CFMCU", JdeDataType.String, 24),
        new JdeField("CFOBJ", "CFOBJ", JdeDataType.String, 12),
        new JdeField("CFSUB", "CFSUB", JdeDataType.String, 16),
        new JdeField("CFPN", "CFPN", JdeDataType.Numeric),
        new JdeField("CFCTRY", "CFCTRY", JdeDataType.Numeric),
        new JdeField("CFFY", "CFFY", JdeDataType.Numeric),
        new JdeField("CFSBL", "CFSBL", JdeDataType.String, 16),
        new JdeField("CFSBLT", "CFSBLT", JdeDataType.String, 2),
        new JdeField("CFLT", "CFLT", JdeDataType.String, 4, true, true),
        new JdeField("CFVR01", "CFVR01", JdeDataType.String, 50),
        new JdeField("CFAA", "CFAA", JdeDataType.Numeric),
        new JdeField("CFCRCD", "CFCRCD", JdeDataType.String, 6),
        new JdeField("CFACR", "CFACR", JdeDataType.Numeric),
        new JdeField("CFRE", "CFRE", JdeDataType.String, 2),
        new JdeField("CFFUTMATH1", "CFFUTMATH1", JdeDataType.Numeric),
        new JdeField("CFFUTSTR1", "CFFUTSTR1", JdeDataType.String, 100),
        new JdeField("CFFUTDATE1", "CFFUTDATE1", JdeDataType.Numeric),
        new JdeField("CFFUTUO1", "CFFUTUO1", JdeDataType.String, 2),
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFUPMT", "CFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C015_0", "Primary Key on CFDCT, CFDOC, CFKCO, CFDGJ, CFJELN, CFLT, CFEXTL", new[] { "CFDCT", "CFDOC", "CFKCO", "CFDGJ", "CFJELN", "CFLT", "CFEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
