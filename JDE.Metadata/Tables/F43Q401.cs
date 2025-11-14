using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q401 - .
/// </summary>
public class F43Q401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCEVNU.
        /// </summary>
        public const string RCEVNU = "RCEVNU";

        /// <summary>
        /// RCDCTO.
        /// </summary>
        public const string RCDCTO = "RCDCTO";

        /// <summary>
        /// RCKCOO.
        /// </summary>
        public const string RCKCOO = "RCKCOO";

        /// <summary>
        /// RCBIDNUM.
        /// </summary>
        public const string RCBIDNUM = "RCBIDNUM";

        /// <summary>
        /// RCBIDQN.
        /// </summary>
        public const string RCBIDQN = "RCBIDQN";

        /// <summary>
        /// RCAN8.
        /// </summary>
        public const string RCAN8 = "RCAN8";

        /// <summary>
        /// RCRDLN.
        /// </summary>
        public const string RCRDLN = "RCRDLN";

        /// <summary>
        /// RCBRQD.
        /// </summary>
        public const string RCBRQD = "RCBRQD";

        /// <summary>
        /// RCRBQ.
        /// </summary>
        public const string RCRBQ = "RCRBQ";

        /// <summary>
        /// RCBIDCODE.
        /// </summary>
        public const string RCBIDCODE = "RCBIDCODE";

        /// <summary>
        /// RCDESC.
        /// </summary>
        public const string RCDESC = "RCDESC";

        /// <summary>
        /// RCBQTYP.
        /// </summary>
        public const string RCBQTYP = "RCBQTYP";

        /// <summary>
        /// RCQRSP.
        /// </summary>
        public const string RCQRSP = "RCQRSP";

        /// <summary>
        /// RCDTERESP.
        /// </summary>
        public const string RCDTERESP = "RCDTERESP";

        /// <summary>
        /// RCYNR.
        /// </summary>
        public const string RCYNR = "RCYNR";

        /// <summary>
        /// RCLLNR.
        /// </summary>
        public const string RCLLNR = "RCLLNR";

        /// <summary>
        /// RCLIRS.
        /// </summary>
        public const string RCLIRS = "RCLIRS";

        /// <summary>
        /// RCDISBDQ.
        /// </summary>
        public const string RCDISBDQ = "RCDISBDQ";

        /// <summary>
        /// RCRSCR.
        /// </summary>
        public const string RCRSCR = "RCRSCR";

        /// <summary>
        /// RCTXTR.
        /// </summary>
        public const string RCTXTR = "RCTXTR";

        /// <summary>
        /// RCMORS.
        /// </summary>
        public const string RCMORS = "RCMORS";

        /// <summary>
        /// RCFMORS.
        /// </summary>
        public const string RCFMORS = "RCFMORS";

        /// <summary>
        /// RCCRCD.
        /// </summary>
        public const string RCCRCD = "RCCRCD";

        /// <summary>
        /// RCADTRC.
        /// </summary>
        public const string RCADTRC = "RCADTRC";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCTORG.
        /// </summary>
        public const string RCTORG = "RCTORG";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCTDAY.
        /// </summary>
        public const string RCTDAY = "RCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCEVNU", "RCEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDCTO", "RCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RCKCOO", "RCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RCBIDNUM", "RCBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RCBIDQN", "RCBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RCAN8", "RCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RCRDLN", "RCRDLN", JdeDataType.Numeric),
        new JdeField("RCBRQD", "RCBRQD", JdeDataType.String, 2),
        new JdeField("RCRBQ", "RCRBQ", JdeDataType.String, 2),
        new JdeField("RCBIDCODE", "RCBIDCODE", JdeDataType.String, 36),
        new JdeField("RCDESC", "RCDESC", JdeDataType.String, 60),
        new JdeField("RCBQTYP", "RCBQTYP", JdeDataType.String, 4),
        new JdeField("RCQRSP", "RCQRSP", JdeDataType.Numeric),
        new JdeField("RCDTERESP", "RCDTERESP", JdeDataType.Numeric),
        new JdeField("RCYNR", "RCYNR", JdeDataType.String, 2),
        new JdeField("RCLLNR", "RCLLNR", JdeDataType.Numeric),
        new JdeField("RCLIRS", "RCLIRS", JdeDataType.String, 110),
        new JdeField("RCDISBDQ", "RCDISBDQ", JdeDataType.String, 2),
        new JdeField("RCRSCR", "RCRSCR", JdeDataType.Numeric),
        new JdeField("RCTXTR", "RCTXTR", JdeDataType.String, 3998),
        new JdeField("RCMORS", "RCMORS", JdeDataType.Numeric),
        new JdeField("RCFMORS", "RCFMORS", JdeDataType.Numeric),
        new JdeField("RCCRCD", "RCCRCD", JdeDataType.String, 6),
        new JdeField("RCADTRC", "RCADTRC", JdeDataType.String, 2000),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCTORG", "RCTORG", JdeDataType.String, 20),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCTDAY", "RCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q401_0", "Primary Key on RCEVNU, RCDCTO, RCKCOO, RCBIDNUM, RCBIDQN, RCAN8", new[] { "RCEVNU", "RCDCTO", "RCKCOO", "RCBIDNUM", "RCBIDQN", "RCAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q401_2", "Index on RCEVNU, RCDCTO, RCKCOO, RCBIDNUM, RCAN8", new[] { "RCEVNU", "RCDCTO", "RCKCOO", "RCBIDNUM", "RCAN8" }),
        new JdeIndex("F43Q401_3", "Index on RCEVNU, RCDCTO, RCKCOO, RCAN8, RCBIDNUM, RCBIDQN", new[] { "RCEVNU", "RCDCTO", "RCKCOO", "RCAN8", "RCBIDNUM", "RCBIDQN" })
    };
}
