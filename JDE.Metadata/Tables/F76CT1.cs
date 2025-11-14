using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CT1 - .
/// </summary>
public class F76CT1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIICU.
        /// </summary>
        public const string TIICU = "TIICU";

        /// <summary>
        /// TIICUT.
        /// </summary>
        public const string TIICUT = "TIICUT";

        /// <summary>
        /// TICTRY.
        /// </summary>
        public const string TICTRY = "TICTRY";

        /// <summary>
        /// TIFY.
        /// </summary>
        public const string TIFY = "TIFY";

        /// <summary>
        /// TICO.
        /// </summary>
        public const string TICO = "TICO";

        /// <summary>
        /// TILT.
        /// </summary>
        public const string TILT = "TILT";

        /// <summary>
        /// TIDCT.
        /// </summary>
        public const string TIDCT = "TIDCT";

        /// <summary>
        /// TIDOC.
        /// </summary>
        public const string TIDOC = "TIDOC";

        /// <summary>
        /// TISFX.
        /// </summary>
        public const string TISFX = "TISFX";

        /// <summary>
        /// TIAN8.
        /// </summary>
        public const string TIAN8 = "TIAN8";

        /// <summary>
        /// TIPN.
        /// </summary>
        public const string TIPN = "TIPN";

        /// <summary>
        /// TIDGJ.
        /// </summary>
        public const string TIDGJ = "TIDGJ";

        /// <summary>
        /// TIDSVJ.
        /// </summary>
        public const string TIDSVJ = "TIDSVJ";

        /// <summary>
        /// TIJELN.
        /// </summary>
        public const string TIJELN = "TIJELN";

        /// <summary>
        /// TIMCU.
        /// </summary>
        public const string TIMCU = "TIMCU";

        /// <summary>
        /// TIOBJ.
        /// </summary>
        public const string TIOBJ = "TIOBJ";

        /// <summary>
        /// TISUB.
        /// </summary>
        public const string TISUB = "TISUB";

        /// <summary>
        /// TISBL.
        /// </summary>
        public const string TISBL = "TISBL";

        /// <summary>
        /// TISBLT.
        /// </summary>
        public const string TISBLT = "TISBLT";

        /// <summary>
        /// TICJCN.
        /// </summary>
        public const string TICJCN = "TICJCN";

        /// <summary>
        /// TICJCD.
        /// </summary>
        public const string TICJCD = "TICJCD";

        /// <summary>
        /// TICJCB.
        /// </summary>
        public const string TICJCB = "TICJCB";

        /// <summary>
        /// TICJCI.
        /// </summary>
        public const string TICJCI = "TICJCI";

        /// <summary>
        /// TIRT.
        /// </summary>
        public const string TIRT = "TIRT";

        /// <summary>
        /// TICJCS.
        /// </summary>
        public const string TICJCS = "TICJCS";

        /// <summary>
        /// TICJCA.
        /// </summary>
        public const string TICJCA = "TICJCA";

        /// <summary>
        /// TIALT6.
        /// </summary>
        public const string TIALT6 = "TIALT6";

        /// <summary>
        /// TITAXC.
        /// </summary>
        public const string TITAXC = "TITAXC";

        /// <summary>
        /// TIUSER.
        /// </summary>
        public const string TIUSER = "TIUSER";

        /// <summary>
        /// TIPID.
        /// </summary>
        public const string TIPID = "TIPID";

        /// <summary>
        /// TIJOBN.
        /// </summary>
        public const string TIJOBN = "TIJOBN";

        /// <summary>
        /// TIUPMJ.
        /// </summary>
        public const string TIUPMJ = "TIUPMJ";

        /// <summary>
        /// TIUPMT.
        /// </summary>
        public const string TIUPMT = "TIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76CT1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIICU", "TIICU", JdeDataType.Numeric, null, true, true),
        new JdeField("TIICUT", "TIICUT", JdeDataType.String, 4, true, true),
        new JdeField("TICTRY", "TICTRY", JdeDataType.Numeric),
        new JdeField("TIFY", "TIFY", JdeDataType.Numeric),
        new JdeField("TICO", "TICO", JdeDataType.String, 10, true, true),
        new JdeField("TILT", "TILT", JdeDataType.String, 4),
        new JdeField("TIDCT", "TIDCT", JdeDataType.String, 4, true, true),
        new JdeField("TIDOC", "TIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TISFX", "TISFX", JdeDataType.String, 6),
        new JdeField("TIAN8", "TIAN8", JdeDataType.Numeric),
        new JdeField("TIPN", "TIPN", JdeDataType.Numeric),
        new JdeField("TIDGJ", "TIDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TIDSVJ", "TIDSVJ", JdeDataType.Numeric),
        new JdeField("TIJELN", "TIJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("TIMCU", "TIMCU", JdeDataType.String, 24),
        new JdeField("TIOBJ", "TIOBJ", JdeDataType.String, 12),
        new JdeField("TISUB", "TISUB", JdeDataType.String, 16),
        new JdeField("TISBL", "TISBL", JdeDataType.String, 16),
        new JdeField("TISBLT", "TISBLT", JdeDataType.String, 2),
        new JdeField("TICJCN", "TICJCN", JdeDataType.Numeric),
        new JdeField("TICJCD", "TICJCD", JdeDataType.String, 2),
        new JdeField("TICJCB", "TICJCB", JdeDataType.Numeric),
        new JdeField("TICJCI", "TICJCI", JdeDataType.Numeric),
        new JdeField("TIRT", "TIRT", JdeDataType.String, 4),
        new JdeField("TICJCS", "TICJCS", JdeDataType.String, 6),
        new JdeField("TICJCA", "TICJCA", JdeDataType.String, 120),
        new JdeField("TIALT6", "TIALT6", JdeDataType.String, 2),
        new JdeField("TITAXC", "TITAXC", JdeDataType.String, 2),
        new JdeField("TIUSER", "TIUSER", JdeDataType.String, 20),
        new JdeField("TIPID", "TIPID", JdeDataType.String, 20),
        new JdeField("TIJOBN", "TIJOBN", JdeDataType.String, 20),
        new JdeField("TIUPMJ", "TIUPMJ", JdeDataType.Numeric),
        new JdeField("TIUPMT", "TIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CT1_0", "Primary Key on TICO, TIICUT, TIICU, TIDCT, TIDOC, TIJELN, TIDGJ", new[] { "TICO", "TIICUT", "TIICU", "TIDCT", "TIDOC", "TIJELN", "TIDGJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76CT1_2", "Index on TICO, TICJCN, TIDCT, TIDOC", new[] { "TICO", "TICJCN", "TIDCT", "TIDOC" })
    };
}
