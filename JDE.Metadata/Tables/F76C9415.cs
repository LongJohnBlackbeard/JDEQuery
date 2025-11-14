using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C9415 - .
/// </summary>
public class F76C9415 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDMATH01.
        /// </summary>
        public const string LDMATH01 = "LDMATH01";

        /// <summary>
        /// LDCO.
        /// </summary>
        public const string LDCO = "LDCO";

        /// <summary>
        /// LDICUT.
        /// </summary>
        public const string LDICUT = "LDICUT";

        /// <summary>
        /// LDICU.
        /// </summary>
        public const string LDICU = "LDICU";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDDOC.
        /// </summary>
        public const string LDDOC = "LDDOC";

        /// <summary>
        /// LDANI.
        /// </summary>
        public const string LDANI = "LDANI";

        /// <summary>
        /// LDAID.
        /// </summary>
        public const string LDAID = "LDAID";

        /// <summary>
        /// LDMCU.
        /// </summary>
        public const string LDMCU = "LDMCU";

        /// <summary>
        /// LDOBJ.
        /// </summary>
        public const string LDOBJ = "LDOBJ";

        /// <summary>
        /// LDSUB.
        /// </summary>
        public const string LDSUB = "LDSUB";

        /// <summary>
        /// LDLT.
        /// </summary>
        public const string LDLT = "LDLT";

        /// <summary>
        /// LDDGJ.
        /// </summary>
        public const string LDDGJ = "LDDGJ";

        /// <summary>
        /// LDPOST.
        /// </summary>
        public const string LDPOST = "LDPOST";

        /// <summary>
        /// LDEXTL.
        /// </summary>
        public const string LDEXTL = "LDEXTL";

        /// <summary>
        /// LDAN01.
        /// </summary>
        public const string LDAN01 = "LDAN01";

        /// <summary>
        /// LDAN02.
        /// </summary>
        public const string LDAN02 = "LDAN02";

        /// <summary>
        /// LDCTRY.
        /// </summary>
        public const string LDCTRY = "LDCTRY";

        /// <summary>
        /// LDFY.
        /// </summary>
        public const string LDFY = "LDFY";

        /// <summary>
        /// LDPN.
        /// </summary>
        public const string LDPN = "LDPN";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C9415";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDMATH01", "LDMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("LDCO", "LDCO", JdeDataType.String, 10),
        new JdeField("LDICUT", "LDICUT", JdeDataType.String, 4),
        new JdeField("LDICU", "LDICU", JdeDataType.Numeric),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4),
        new JdeField("LDDOC", "LDDOC", JdeDataType.Numeric),
        new JdeField("LDANI", "LDANI", JdeDataType.String, 58),
        new JdeField("LDAID", "LDAID", JdeDataType.String, 16),
        new JdeField("LDMCU", "LDMCU", JdeDataType.String, 24),
        new JdeField("LDOBJ", "LDOBJ", JdeDataType.String, 12),
        new JdeField("LDSUB", "LDSUB", JdeDataType.String, 16),
        new JdeField("LDLT", "LDLT", JdeDataType.String, 4),
        new JdeField("LDDGJ", "LDDGJ", JdeDataType.Numeric),
        new JdeField("LDPOST", "LDPOST", JdeDataType.String, 2),
        new JdeField("LDEXTL", "LDEXTL", JdeDataType.String, 4),
        new JdeField("LDAN01", "LDAN01", JdeDataType.Numeric),
        new JdeField("LDAN02", "LDAN02", JdeDataType.Numeric),
        new JdeField("LDCTRY", "LDCTRY", JdeDataType.Numeric),
        new JdeField("LDFY", "LDFY", JdeDataType.Numeric),
        new JdeField("LDPN", "LDPN", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20, true, true),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20, true, true),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C9415_0", "Primary Key on LDUSER, LDJOBN, LDUPMJ, LDUPMT, LDMATH01", new[] { "LDUSER", "LDJOBN", "LDUPMJ", "LDUPMT", "LDMATH01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C9415_2", "Index on LDICUT, LDICU, LDLT", new[] { "LDICUT", "LDICU", "LDLT" }),
        new JdeIndex("F76C9415_3", "Index on LDDOC, LDDCT, LDLT", new[] { "LDDOC", "LDDCT", "LDLT" })
    };
}
