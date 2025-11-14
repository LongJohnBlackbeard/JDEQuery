using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08920 - .
/// </summary>
public class F08920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JSPAN8.
        /// </summary>
        public const string JSPAN8 = "JSPAN8";

        /// <summary>
        /// JSQE1.
        /// </summary>
        public const string JSQE1 = "JSQE1";

        /// <summary>
        /// JSQD1.
        /// </summary>
        public const string JSQD1 = "JSQD1";

        /// <summary>
        /// JSRPA8.
        /// </summary>
        public const string JSRPA8 = "JSRPA8";

        /// <summary>
        /// JSPLAN.
        /// </summary>
        public const string JSPLAN = "JSPLAN";

        /// <summary>
        /// JSAOPT.
        /// </summary>
        public const string JSAOPT = "JSAOPT";

        /// <summary>
        /// JSUN.
        /// </summary>
        public const string JSUN = "JSUN";

        /// <summary>
        /// JSJBCD.
        /// </summary>
        public const string JSJBCD = "JSJBCD";

        /// <summary>
        /// JSJBST.
        /// </summary>
        public const string JSJBST = "JSJBST";

        /// <summary>
        /// JSFDBA.
        /// </summary>
        public const string JSFDBA = "JSFDBA";

        /// <summary>
        /// JSSDBA.
        /// </summary>
        public const string JSSDBA = "JSSDBA";

        /// <summary>
        /// JSCP.
        /// </summary>
        public const string JSCP = "JSCP";

        /// <summary>
        /// JSPREP.
        /// </summary>
        public const string JSPREP = "JSPREP";

        /// <summary>
        /// JSQBA.
        /// </summary>
        public const string JSQBA = "JSQBA";

        /// <summary>
        /// JSPBL.
        /// </summary>
        public const string JSPBL = "JSPBL";

        /// <summary>
        /// JSPHCD.
        /// </summary>
        public const string JSPHCD = "JSPHCD";

        /// <summary>
        /// JSPAHC.
        /// </summary>
        public const string JSPAHC = "JSPAHC";

        /// <summary>
        /// JSCPD.
        /// </summary>
        public const string JSCPD = "JSCPD";

        /// <summary>
        /// JSCVP.
        /// </summary>
        public const string JSCVP = "JSCVP";

        /// <summary>
        /// JSCPC1.
        /// </summary>
        public const string JSCPC1 = "JSCPC1";

        /// <summary>
        /// JSNPR.
        /// </summary>
        public const string JSNPR = "JSNPR";

        /// <summary>
        /// JSNPX.
        /// </summary>
        public const string JSNPX = "JSNPX";

        /// <summary>
        /// JSDLP.
        /// </summary>
        public const string JSDLP = "JSDLP";

        /// <summary>
        /// JSFOC.
        /// </summary>
        public const string JSFOC = "JSFOC";

        /// <summary>
        /// JSCBCI.
        /// </summary>
        public const string JSCBCI = "JSCBCI";

        /// <summary>
        /// JSDWV.
        /// </summary>
        public const string JSDWV = "JSDWV";

        /// <summary>
        /// JSDTWR.
        /// </summary>
        public const string JSDTWR = "JSDTWR";

        /// <summary>
        /// JSCYST.
        /// </summary>
        public const string JSCYST = "JSCYST";

        /// <summary>
        /// JSEFTB.
        /// </summary>
        public const string JSEFTB = "JSEFTB";

        /// <summary>
        /// JSEFTE.
        /// </summary>
        public const string JSEFTE = "JSEFTE";

        /// <summary>
        /// JSCPPC.
        /// </summary>
        public const string JSCPPC = "JSCPPC";

        /// <summary>
        /// JSDTET.
        /// </summary>
        public const string JSDTET = "JSDTET";

        /// <summary>
        /// JSRPTR.
        /// </summary>
        public const string JSRPTR = "JSRPTR";

        /// <summary>
        /// JSDCE.
        /// </summary>
        public const string JSDCE = "JSDCE";

        /// <summary>
        /// JSAN82.
        /// </summary>
        public const string JSAN82 = "JSAN82";

        /// <summary>
        /// JSUSER.
        /// </summary>
        public const string JSUSER = "JSUSER";

        /// <summary>
        /// JSEAP.
        /// </summary>
        public const string JSEAP = "JSEAP";

        /// <summary>
        /// JSMACH.
        /// </summary>
        public const string JSMACH = "JSMACH";

        /// <summary>
        /// JSUPMJ.
        /// </summary>
        public const string JSUPMJ = "JSUPMJ";

        /// <summary>
        /// JSUPMT.
        /// </summary>
        public const string JSUPMT = "JSUPMT";

        /// <summary>
        /// JSDCR.
        /// </summary>
        public const string JSDCR = "JSDCR";

        /// <summary>
        /// JSDCPT.
        /// </summary>
        public const string JSDCPT = "JSDCPT";
    }

    /// <inheritdoc />
    public override string TableName => "F08920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JSPAN8", "JSPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JSQE1", "JSQE1", JdeDataType.String, 4, true, true),
        new JdeField("JSQD1", "JSQD1", JdeDataType.Numeric, null, true, true),
        new JdeField("JSRPA8", "JSRPA8", JdeDataType.Numeric),
        new JdeField("JSPLAN", "JSPLAN", JdeDataType.String, 16, true, true),
        new JdeField("JSAOPT", "JSAOPT", JdeDataType.String, 6, true, true),
        new JdeField("JSUN", "JSUN", JdeDataType.String, 12),
        new JdeField("JSJBCD", "JSJBCD", JdeDataType.String, 12),
        new JdeField("JSJBST", "JSJBST", JdeDataType.String, 8),
        new JdeField("JSFDBA", "JSFDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JSSDBA", "JSSDBA", JdeDataType.Numeric),
        new JdeField("JSCP", "JSCP", JdeDataType.Numeric),
        new JdeField("JSPREP", "JSPREP", JdeDataType.Numeric),
        new JdeField("JSQBA", "JSQBA", JdeDataType.Numeric),
        new JdeField("JSPBL", "JSPBL", JdeDataType.Numeric),
        new JdeField("JSPHCD", "JSPHCD", JdeDataType.Numeric),
        new JdeField("JSPAHC", "JSPAHC", JdeDataType.Numeric),
        new JdeField("JSCPD", "JSCPD", JdeDataType.Numeric),
        new JdeField("JSCVP", "JSCVP", JdeDataType.Numeric),
        new JdeField("JSCPC1", "JSCPC1", JdeDataType.String, 2),
        new JdeField("JSNPR", "JSNPR", JdeDataType.Numeric),
        new JdeField("JSNPX", "JSNPX", JdeDataType.Numeric),
        new JdeField("JSDLP", "JSDLP", JdeDataType.Numeric),
        new JdeField("JSFOC", "JSFOC", JdeDataType.String, 2),
        new JdeField("JSCBCI", "JSCBCI", JdeDataType.Numeric),
        new JdeField("JSDWV", "JSDWV", JdeDataType.Numeric),
        new JdeField("JSDTWR", "JSDTWR", JdeDataType.Numeric),
        new JdeField("JSCYST", "JSCYST", JdeDataType.String, 2),
        new JdeField("JSEFTB", "JSEFTB", JdeDataType.Numeric),
        new JdeField("JSEFTE", "JSEFTE", JdeDataType.Numeric),
        new JdeField("JSCPPC", "JSCPPC", JdeDataType.Numeric),
        new JdeField("JSDTET", "JSDTET", JdeDataType.Numeric),
        new JdeField("JSRPTR", "JSRPTR", JdeDataType.String, 4),
        new JdeField("JSDCE", "JSDCE", JdeDataType.Numeric),
        new JdeField("JSAN82", "JSAN82", JdeDataType.Numeric),
        new JdeField("JSUSER", "JSUSER", JdeDataType.String, 20),
        new JdeField("JSEAP", "JSEAP", JdeDataType.String, 20),
        new JdeField("JSMACH", "JSMACH", JdeDataType.String, 24),
        new JdeField("JSUPMJ", "JSUPMJ", JdeDataType.Numeric),
        new JdeField("JSUPMT", "JSUPMT", JdeDataType.Numeric),
        new JdeField("JSDCR", "JSDCR", JdeDataType.Numeric),
        new JdeField("JSDCPT", "JSDCPT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08920_0", "Primary Key on JSPAN8, JSQE1, JSQD1, JSPLAN, JSAOPT, JSFDBA", new[] { "JSPAN8", "JSQE1", "JSQD1", "JSPLAN", "JSAOPT", "JSFDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08920_2", "Index on JSPAN8, JSQE1, JSQD1, JSCYST", new[] { "JSPAN8", "JSQE1", "JSQD1", "JSCYST" }),
        new JdeIndex("F08920_3", "Index on JSPLAN, JSAOPT, JSPAN8", new[] { "JSPLAN", "JSAOPT", "JSPAN8" }),
        new JdeIndex("F08920_4", "Index on JSQE1, JSQD1, JSAN82", new[] { "JSQE1", "JSQD1", "JSAN82" }),
        new JdeIndex("F08920_5", "Index on JSPAN8, JSQE1, JSQD1, JSFDBA", new[] { "JSPAN8", "JSQE1", "JSQD1", "JSFDBA" })
    };
}
