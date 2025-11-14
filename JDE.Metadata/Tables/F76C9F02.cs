using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C9F02 - .
/// </summary>
public class F76C9F02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DFC76FMT.
        /// </summary>
        public const string DFC76FMT = "DFC76FMT";

        /// <summary>
        /// DFKCO.
        /// </summary>
        public const string DFKCO = "DFKCO";

        /// <summary>
        /// DFDCT.
        /// </summary>
        public const string DFDCT = "DFDCT";

        /// <summary>
        /// DFDOC.
        /// </summary>
        public const string DFDOC = "DFDOC";

        /// <summary>
        /// DFDGJ.
        /// </summary>
        public const string DFDGJ = "DFDGJ";

        /// <summary>
        /// DFJELN.
        /// </summary>
        public const string DFJELN = "DFJELN";

        /// <summary>
        /// DFEXTL.
        /// </summary>
        public const string DFEXTL = "DFEXTL";

        /// <summary>
        /// DFLT.
        /// </summary>
        public const string DFLT = "DFLT";

        /// <summary>
        /// DFICU.
        /// </summary>
        public const string DFICU = "DFICU";

        /// <summary>
        /// DFICUT.
        /// </summary>
        public const string DFICUT = "DFICUT";

        /// <summary>
        /// DFDICJ.
        /// </summary>
        public const string DFDICJ = "DFDICJ";

        /// <summary>
        /// DFSBL.
        /// </summary>
        public const string DFSBL = "DFSBL";

        /// <summary>
        /// DFSBLT.
        /// </summary>
        public const string DFSBLT = "DFSBLT";

        /// <summary>
        /// DFCTRY.
        /// </summary>
        public const string DFCTRY = "DFCTRY";

        /// <summary>
        /// DFFY.
        /// </summary>
        public const string DFFY = "DFFY";

        /// <summary>
        /// DFCRCD.
        /// </summary>
        public const string DFCRCD = "DFCRCD";

        /// <summary>
        /// DFEXA.
        /// </summary>
        public const string DFEXA = "DFEXA";

        /// <summary>
        /// DFPOST.
        /// </summary>
        public const string DFPOST = "DFPOST";

        /// <summary>
        /// DFRE.
        /// </summary>
        public const string DFRE = "DFRE";

        /// <summary>
        /// DFANI.
        /// </summary>
        public const string DFANI = "DFANI";

        /// <summary>
        /// DFAID.
        /// </summary>
        public const string DFAID = "DFAID";

        /// <summary>
        /// DFMCU.
        /// </summary>
        public const string DFMCU = "DFMCU";

        /// <summary>
        /// DFOBJ.
        /// </summary>
        public const string DFOBJ = "DFOBJ";

        /// <summary>
        /// DFSUB.
        /// </summary>
        public const string DFSUB = "DFSUB";

        /// <summary>
        /// DFAN8.
        /// </summary>
        public const string DFAN8 = "DFAN8";

        /// <summary>
        /// DFAA1.
        /// </summary>
        public const string DFAA1 = "DFAA1";

        /// <summary>
        /// DFAA2.
        /// </summary>
        public const string DFAA2 = "DFAA2";

        /// <summary>
        /// DF76CTAX.
        /// </summary>
        public const string DF76CTAX = "DF76CTAX";

        /// <summary>
        /// DFC76TAXA.
        /// </summary>
        public const string DFC76TAXA = "DFC76TAXA";

        /// <summary>
        /// DFC76CEPT.
        /// </summary>
        public const string DFC76CEPT = "DFC76CEPT";

        /// <summary>
        /// DFC76STS.
        /// </summary>
        public const string DFC76STS = "DFC76STS";

        /// <summary>
        /// DFC76DDCT.
        /// </summary>
        public const string DFC76DDCT = "DFC76DDCT";

        /// <summary>
        /// DFSEQ.
        /// </summary>
        public const string DFSEQ = "DFSEQ";

        /// <summary>
        /// DFC76TYACC.
        /// </summary>
        public const string DFC76TYACC = "DFC76TYACC";

        /// <summary>
        /// DFC76DEDU.
        /// </summary>
        public const string DFC76DEDU = "DFC76DEDU";

        /// <summary>
        /// DFC76CLAS1.
        /// </summary>
        public const string DFC76CLAS1 = "DFC76CLAS1";

        /// <summary>
        /// DFC76CLAS2.
        /// </summary>
        public const string DFC76CLAS2 = "DFC76CLAS2";

        /// <summary>
        /// DFC76CLAS3.
        /// </summary>
        public const string DFC76CLAS3 = "DFC76CLAS3";

        /// <summary>
        /// DFPID.
        /// </summary>
        public const string DFPID = "DFPID";

        /// <summary>
        /// DFUSER.
        /// </summary>
        public const string DFUSER = "DFUSER";

        /// <summary>
        /// DFVERS.
        /// </summary>
        public const string DFVERS = "DFVERS";

        /// <summary>
        /// DFJOBN.
        /// </summary>
        public const string DFJOBN = "DFJOBN";

        /// <summary>
        /// DFUPMT.
        /// </summary>
        public const string DFUPMT = "DFUPMT";

        /// <summary>
        /// DFUPMJ.
        /// </summary>
        public const string DFUPMJ = "DFUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76C9F02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DFC76FMT", "DFC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("DFKCO", "DFKCO", JdeDataType.String, 10, true, true),
        new JdeField("DFDCT", "DFDCT", JdeDataType.String, 4, true, true),
        new JdeField("DFDOC", "DFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DFDGJ", "DFDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DFJELN", "DFJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("DFEXTL", "DFEXTL", JdeDataType.String, 4, true, true),
        new JdeField("DFLT", "DFLT", JdeDataType.String, 4, true, true),
        new JdeField("DFICU", "DFICU", JdeDataType.Numeric),
        new JdeField("DFICUT", "DFICUT", JdeDataType.String, 4),
        new JdeField("DFDICJ", "DFDICJ", JdeDataType.Numeric),
        new JdeField("DFSBL", "DFSBL", JdeDataType.String, 16),
        new JdeField("DFSBLT", "DFSBLT", JdeDataType.String, 2),
        new JdeField("DFCTRY", "DFCTRY", JdeDataType.Numeric),
        new JdeField("DFFY", "DFFY", JdeDataType.Numeric),
        new JdeField("DFCRCD", "DFCRCD", JdeDataType.String, 6),
        new JdeField("DFEXA", "DFEXA", JdeDataType.String, 60),
        new JdeField("DFPOST", "DFPOST", JdeDataType.String, 2),
        new JdeField("DFRE", "DFRE", JdeDataType.String, 2),
        new JdeField("DFANI", "DFANI", JdeDataType.String, 58),
        new JdeField("DFAID", "DFAID", JdeDataType.String, 16),
        new JdeField("DFMCU", "DFMCU", JdeDataType.String, 24),
        new JdeField("DFOBJ", "DFOBJ", JdeDataType.String, 12),
        new JdeField("DFSUB", "DFSUB", JdeDataType.String, 16),
        new JdeField("DFAN8", "DFAN8", JdeDataType.Numeric),
        new JdeField("DFAA1", "DFAA1", JdeDataType.Numeric),
        new JdeField("DFAA2", "DFAA2", JdeDataType.Numeric),
        new JdeField("DF76CTAX", "DF76CTAX", JdeDataType.String, 40),
        new JdeField("DFC76TAXA", "DFC76TAXA", JdeDataType.String, 40),
        new JdeField("DFC76CEPT", "DFC76CEPT", JdeDataType.String, 8),
        new JdeField("DFC76STS", "DFC76STS", JdeDataType.String, 2),
        new JdeField("DFC76DDCT", "DFC76DDCT", JdeDataType.Numeric),
        new JdeField("DFSEQ", "DFSEQ", JdeDataType.Numeric),
        new JdeField("DFC76TYACC", "DFC76TYACC", JdeDataType.String, 4),
        new JdeField("DFC76DEDU", "DFC76DEDU", JdeDataType.String, 2),
        new JdeField("DFC76CLAS1", "DFC76CLAS1", JdeDataType.String, 6),
        new JdeField("DFC76CLAS2", "DFC76CLAS2", JdeDataType.String, 6),
        new JdeField("DFC76CLAS3", "DFC76CLAS3", JdeDataType.String, 6),
        new JdeField("DFPID", "DFPID", JdeDataType.String, 20),
        new JdeField("DFUSER", "DFUSER", JdeDataType.String, 20),
        new JdeField("DFVERS", "DFVERS", JdeDataType.String, 20),
        new JdeField("DFJOBN", "DFJOBN", JdeDataType.String, 20),
        new JdeField("DFUPMT", "DFUPMT", JdeDataType.Numeric),
        new JdeField("DFUPMJ", "DFUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C9F02_0", "Primary Key on DFC76FMT, DFKCO, DFDCT, DFDOC, DFDGJ, DFJELN, DFEXTL, DFLT", new[] { "DFC76FMT", "DFKCO", "DFDCT", "DFDOC", "DFDGJ", "DFJELN", "DFEXTL", "DFLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C9F02_2", "Index on DFC76FMT, DFC76CEPT, DFC76DDCT, DF76CTAX", new[] { "DFC76FMT", "DFC76CEPT", "DFC76DDCT", "DF76CTAX" }),
        new JdeIndex("F76C9F02_3", "Index on DFC76FMT, DF76CTAX", new[] { "DFC76FMT", "DF76CTAX" }),
        new JdeIndex("F76C9F02_4", "Index on DFC76FMT, DFAN8", new[] { "DFC76FMT", "DFAN8" })
    };
}
