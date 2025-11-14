using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4952 - .
/// </summary>
public class F4952 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RERTN.
        /// </summary>
        public const string RERTN = "RERTN";

        /// <summary>
        /// REMOT.
        /// </summary>
        public const string REMOT = "REMOT";

        /// <summary>
        /// RECARS.
        /// </summary>
        public const string RECARS = "RECARS";

        /// <summary>
        /// REMNWT.
        /// </summary>
        public const string REMNWT = "REMNWT";

        /// <summary>
        /// REMXWT.
        /// </summary>
        public const string REMXWT = "REMXWT";

        /// <summary>
        /// REMNPW.
        /// </summary>
        public const string REMNPW = "REMNPW";

        /// <summary>
        /// REMXPW.
        /// </summary>
        public const string REMXPW = "REMXPW";

        /// <summary>
        /// REWTUM.
        /// </summary>
        public const string REWTUM = "REWTUM";

        /// <summary>
        /// REMNCB.
        /// </summary>
        public const string REMNCB = "REMNCB";

        /// <summary>
        /// REMXCB.
        /// </summary>
        public const string REMXCB = "REMXCB";

        /// <summary>
        /// REVLUM.
        /// </summary>
        public const string REVLUM = "REVLUM";

        /// <summary>
        /// REMXLN.
        /// </summary>
        public const string REMXLN = "REMXLN";

        /// <summary>
        /// REMXWD.
        /// </summary>
        public const string REMXWD = "REMXWD";

        /// <summary>
        /// REMXHT.
        /// </summary>
        public const string REMXHT = "REMXHT";

        /// <summary>
        /// REMXGT.
        /// </summary>
        public const string REMXGT = "REMXGT";

        /// <summary>
        /// REMXGL.
        /// </summary>
        public const string REMXGL = "REMXGL";

        /// <summary>
        /// RELUOM.
        /// </summary>
        public const string RELUOM = "RELUOM";

        /// <summary>
        /// REMXPC.
        /// </summary>
        public const string REMXPC = "REMXPC";

        /// <summary>
        /// REMXST.
        /// </summary>
        public const string REMXST = "REMXST";

        /// <summary>
        /// REURCD.
        /// </summary>
        public const string REURCD = "REURCD";

        /// <summary>
        /// REURDT.
        /// </summary>
        public const string REURDT = "REURDT";

        /// <summary>
        /// REURAB.
        /// </summary>
        public const string REURAB = "REURAB";

        /// <summary>
        /// REURAT.
        /// </summary>
        public const string REURAT = "REURAT";

        /// <summary>
        /// REURRF.
        /// </summary>
        public const string REURRF = "REURRF";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// RETDAY.
        /// </summary>
        public const string RETDAY = "RETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4952";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RERTN", "RERTN", JdeDataType.Numeric, null, true, true),
        new JdeField("REMOT", "REMOT", JdeDataType.String, 6, true, true),
        new JdeField("RECARS", "RECARS", JdeDataType.Numeric, null, true, true),
        new JdeField("REMNWT", "REMNWT", JdeDataType.Numeric),
        new JdeField("REMXWT", "REMXWT", JdeDataType.Numeric),
        new JdeField("REMNPW", "REMNPW", JdeDataType.Numeric),
        new JdeField("REMXPW", "REMXPW", JdeDataType.Numeric),
        new JdeField("REWTUM", "REWTUM", JdeDataType.String, 4),
        new JdeField("REMNCB", "REMNCB", JdeDataType.Numeric),
        new JdeField("REMXCB", "REMXCB", JdeDataType.Numeric),
        new JdeField("REVLUM", "REVLUM", JdeDataType.String, 4),
        new JdeField("REMXLN", "REMXLN", JdeDataType.Numeric),
        new JdeField("REMXWD", "REMXWD", JdeDataType.Numeric),
        new JdeField("REMXHT", "REMXHT", JdeDataType.Numeric),
        new JdeField("REMXGT", "REMXGT", JdeDataType.Numeric),
        new JdeField("REMXGL", "REMXGL", JdeDataType.Numeric),
        new JdeField("RELUOM", "RELUOM", JdeDataType.String, 4),
        new JdeField("REMXPC", "REMXPC", JdeDataType.Numeric),
        new JdeField("REMXST", "REMXST", JdeDataType.Numeric),
        new JdeField("REURCD", "REURCD", JdeDataType.String, 4),
        new JdeField("REURDT", "REURDT", JdeDataType.Numeric),
        new JdeField("REURAB", "REURAB", JdeDataType.Numeric),
        new JdeField("REURAT", "REURAT", JdeDataType.Numeric),
        new JdeField("REURRF", "REURRF", JdeDataType.String, 30),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("RETDAY", "RETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4952_0", "Primary Key on RERTN, RECARS, REMOT", new[] { "RERTN", "RECARS", "REMOT" }, isUnique: true, isPrimaryKey: true)
    };
}
