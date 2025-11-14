using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I345 - .
/// </summary>
public class F75I345 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QRYEXU.
        /// </summary>
        public const string QRYEXU = "QRYEXU";

        /// <summary>
        /// QRYAR3N.
        /// </summary>
        public const string QRYAR3N = "QRYAR3N";

        /// <summary>
        /// QRYSUF.
        /// </summary>
        public const string QRYSUF = "QRYSUF";

        /// <summary>
        /// QRYARD.
        /// </summary>
        public const string QRYARD = "QRYARD";

        /// <summary>
        /// QRYAR3D.
        /// </summary>
        public const string QRYAR3D = "QRYAR3D";

        /// <summary>
        /// QRA301.
        /// </summary>
        public const string QRA301 = "QRA301";

        /// <summary>
        /// QRDESC.
        /// </summary>
        public const string QRDESC = "QRDESC";

        /// <summary>
        /// QREDER.
        /// </summary>
        public const string QREDER = "QREDER";

        /// <summary>
        /// QRKCOO.
        /// </summary>
        public const string QRKCOO = "QRKCOO";

        /// <summary>
        /// QRDOCO.
        /// </summary>
        public const string QRDOCO = "QRDOCO";

        /// <summary>
        /// QRDCTO.
        /// </summary>
        public const string QRDCTO = "QRDCTO";

        /// <summary>
        /// QRKCO.
        /// </summary>
        public const string QRKCO = "QRKCO";

        /// <summary>
        /// QRDOC.
        /// </summary>
        public const string QRDOC = "QRDOC";

        /// <summary>
        /// QRDCT.
        /// </summary>
        public const string QRDCT = "QRDCT";

        /// <summary>
        /// QRASVL.
        /// </summary>
        public const string QRASVL = "QRASVL";

        /// <summary>
        /// QRYEXA.
        /// </summary>
        public const string QRYEXA = "QRYEXA";

        /// <summary>
        /// QRI75BED.
        /// </summary>
        public const string QRI75BED = "QRI75BED";

        /// <summary>
        /// QRI75CESS.
        /// </summary>
        public const string QRI75CESS = "QRI75CESS";

        /// <summary>
        /// QRI75AED.
        /// </summary>
        public const string QRI75AED = "QRI75AED";

        /// <summary>
        /// QRYIAM.
        /// </summary>
        public const string QRYIAM = "QRYIAM";

        /// <summary>
        /// QRI75SED.
        /// </summary>
        public const string QRI75SED = "QRI75SED";

        /// <summary>
        /// QRXOPR.
        /// </summary>
        public const string QRXOPR = "QRXOPR";

        /// <summary>
        /// QRREMK.
        /// </summary>
        public const string QRREMK = "QRREMK";

        /// <summary>
        /// QRMOT.
        /// </summary>
        public const string QRMOT = "QRMOT";

        /// <summary>
        /// QRFLG.
        /// </summary>
        public const string QRFLG = "QRFLG";

        /// <summary>
        /// QREXPUN.
        /// </summary>
        public const string QREXPUN = "QREXPUN";

        /// <summary>
        /// QRYC3D.
        /// </summary>
        public const string QRYC3D = "QRYC3D";

        /// <summary>
        /// QRYEU3.
        /// </summary>
        public const string QRYEU3 = "QRYEU3";

        /// <summary>
        /// QRYA3D.
        /// </summary>
        public const string QRYA3D = "QRYA3D";

        /// <summary>
        /// QRAEXD.
        /// </summary>
        public const string QRAEXD = "QRAEXD";

        /// <summary>
        /// QRTORG.
        /// </summary>
        public const string QRTORG = "QRTORG";

        /// <summary>
        /// QRUSER.
        /// </summary>
        public const string QRUSER = "QRUSER";

        /// <summary>
        /// QRJOBN.
        /// </summary>
        public const string QRJOBN = "QRJOBN";

        /// <summary>
        /// QRPID.
        /// </summary>
        public const string QRPID = "QRPID";

        /// <summary>
        /// QRUPMJ.
        /// </summary>
        public const string QRUPMJ = "QRUPMJ";

        /// <summary>
        /// QRUPMT.
        /// </summary>
        public const string QRUPMT = "QRUPMT";

        /// <summary>
        /// QRTDAY.
        /// </summary>
        public const string QRTDAY = "QRTDAY";

        /// <summary>
        /// QRBDSN.
        /// </summary>
        public const string QRBDSN = "QRBDSN";

        /// <summary>
        /// QRYDFW.
        /// </summary>
        public const string QRYDFW = "QRYDFW";

        /// <summary>
        /// QRYC3N.
        /// </summary>
        public const string QRYC3N = "QRYC3N";

        /// <summary>
        /// QRYOSUF.
        /// </summary>
        public const string QRYOSUF = "QRYOSUF";

        /// <summary>
        /// QRYOA3D.
        /// </summary>
        public const string QRYOA3D = "QRYOA3D";

        /// <summary>
        /// QRYOA3N.
        /// </summary>
        public const string QRYOA3N = "QRYOA3N";

        /// <summary>
        /// QRATDJ.
        /// </summary>
        public const string QRATDJ = "QRATDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75I345";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QRYEXU", "QRYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QRYAR3N", "QRYAR3N", JdeDataType.Numeric, null, true, true),
        new JdeField("QRYSUF", "QRYSUF", JdeDataType.String, 4, true, true),
        new JdeField("QRYARD", "QRYARD", JdeDataType.Numeric, null, true, true),
        new JdeField("QRYAR3D", "QRYAR3D", JdeDataType.Numeric),
        new JdeField("QRA301", "QRA301", JdeDataType.String, 6),
        new JdeField("QRDESC", "QRDESC", JdeDataType.String, 60),
        new JdeField("QREDER", "QREDER", JdeDataType.String, 2),
        new JdeField("QRKCOO", "QRKCOO", JdeDataType.String, 10),
        new JdeField("QRDOCO", "QRDOCO", JdeDataType.Numeric),
        new JdeField("QRDCTO", "QRDCTO", JdeDataType.String, 4),
        new JdeField("QRKCO", "QRKCO", JdeDataType.String, 10),
        new JdeField("QRDOC", "QRDOC", JdeDataType.Numeric),
        new JdeField("QRDCT", "QRDCT", JdeDataType.String, 4),
        new JdeField("QRASVL", "QRASVL", JdeDataType.Numeric),
        new JdeField("QRYEXA", "QRYEXA", JdeDataType.Numeric),
        new JdeField("QRI75BED", "QRI75BED", JdeDataType.Numeric),
        new JdeField("QRI75CESS", "QRI75CESS", JdeDataType.Numeric),
        new JdeField("QRI75AED", "QRI75AED", JdeDataType.Numeric),
        new JdeField("QRYIAM", "QRYIAM", JdeDataType.Numeric),
        new JdeField("QRI75SED", "QRI75SED", JdeDataType.Numeric),
        new JdeField("QRXOPR", "QRXOPR", JdeDataType.String, 120),
        new JdeField("QRREMK", "QRREMK", JdeDataType.String, 60),
        new JdeField("QRMOT", "QRMOT", JdeDataType.String, 6),
        new JdeField("QRFLG", "QRFLG", JdeDataType.String, 2),
        new JdeField("QREXPUN", "QREXPUN", JdeDataType.String, 20),
        new JdeField("QRYC3D", "QRYC3D", JdeDataType.Numeric),
        new JdeField("QRYEU3", "QRYEU3", JdeDataType.Numeric),
        new JdeField("QRYA3D", "QRYA3D", JdeDataType.Numeric),
        new JdeField("QRAEXD", "QRAEXD", JdeDataType.Numeric),
        new JdeField("QRTORG", "QRTORG", JdeDataType.String, 20),
        new JdeField("QRUSER", "QRUSER", JdeDataType.String, 20),
        new JdeField("QRJOBN", "QRJOBN", JdeDataType.String, 20),
        new JdeField("QRPID", "QRPID", JdeDataType.String, 20),
        new JdeField("QRUPMJ", "QRUPMJ", JdeDataType.Numeric),
        new JdeField("QRUPMT", "QRUPMT", JdeDataType.Numeric),
        new JdeField("QRTDAY", "QRTDAY", JdeDataType.Numeric),
        new JdeField("QRBDSN", "QRBDSN", JdeDataType.String, 44),
        new JdeField("QRYDFW", "QRYDFW", JdeDataType.Numeric),
        new JdeField("QRYC3N", "QRYC3N", JdeDataType.Numeric),
        new JdeField("QRYOSUF", "QRYOSUF", JdeDataType.String, 4),
        new JdeField("QRYOA3D", "QRYOA3D", JdeDataType.Numeric),
        new JdeField("QRYOA3N", "QRYOA3N", JdeDataType.Numeric),
        new JdeField("QRATDJ", "QRATDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I345_0", "Primary Key on QRYEXU, QRYAR3N, QRYSUF, QRYARD", new[] { "QRYEXU", "QRYAR3N", "QRYSUF", "QRYARD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I345_2", "Index on QRYEXU, QRKCO, QRDOC, QRDCT", new[] { "QRYEXU", "QRKCO", "QRDOC", "QRDCT" })
    };
}
