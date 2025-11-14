using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B571 - .
/// </summary>
public class F03B571 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCADCN.
        /// </summary>
        public const string RCADCN = "RCADCN";

        /// <summary>
        /// RCUSR0.
        /// </summary>
        public const string RCUSR0 = "RCUSR0";

        /// <summary>
        /// RCVER.
        /// </summary>
        public const string RCVER = "RCVER";

        /// <summary>
        /// RCDEJ.
        /// </summary>
        public const string RCDEJ = "RCDEJ";

        /// <summary>
        /// RCTENT.
        /// </summary>
        public const string RCTENT = "RCTENT";

        /// <summary>
        /// RCICUT.
        /// </summary>
        public const string RCICUT = "RCICUT";

        /// <summary>
        /// RCICU.
        /// </summary>
        public const string RCICU = "RCICU";

        /// <summary>
        /// RCDBST.
        /// </summary>
        public const string RCDBST = "RCDBST";

        /// <summary>
        /// RCNRCV.
        /// </summary>
        public const string RCNRCV = "RCNRCV";

        /// <summary>
        /// RCNINV.
        /// </summary>
        public const string RCNINV = "RCNINV";

        /// <summary>
        /// RCAG.
        /// </summary>
        public const string RCAG = "RCAG";

        /// <summary>
        /// RCADSA.
        /// </summary>
        public const string RCADSA = "RCADSA";

        /// <summary>
        /// RCNAMT.
        /// </summary>
        public const string RCNAMT = "RCNAMT";

        /// <summary>
        /// RCCRCD.
        /// </summary>
        public const string RCCRCD = "RCCRCD";

        /// <summary>
        /// RCGLBA.
        /// </summary>
        public const string RCGLBA = "RCGLBA";

        /// <summary>
        /// RCAM.
        /// </summary>
        public const string RCAM = "RCAM";

        /// <summary>
        /// RCDGJ.
        /// </summary>
        public const string RCDGJ = "RCDGJ";

        /// <summary>
        /// RCBACF.
        /// </summary>
        public const string RCBACF = "RCBACF";

        /// <summary>
        /// RCBACD.
        /// </summary>
        public const string RCBACD = "RCBACD";

        /// <summary>
        /// RCBACN.
        /// </summary>
        public const string RCBACN = "RCBACN";

        /// <summary>
        /// RCCALN.
        /// </summary>
        public const string RCCALN = "RCCALN";

        /// <summary>
        /// RCDDPR.
        /// </summary>
        public const string RCDDPR = "RCDDPR";

        /// <summary>
        /// RCDCDJ.
        /// </summary>
        public const string RCDCDJ = "RCDCDJ";

        /// <summary>
        /// RCPSJE.
        /// </summary>
        public const string RCPSJE = "RCPSJE";

        /// <summary>
        /// RCPGM.
        /// </summary>
        public const string RCPGM = "RCPGM";

        /// <summary>
        /// RCVER2.
        /// </summary>
        public const string RCVER2 = "RCVER2";

        /// <summary>
        /// RCCYMD.
        /// </summary>
        public const string RCCYMD = "RCCYMD";

        /// <summary>
        /// RCPGMG.
        /// </summary>
        public const string RCPGMG = "RCPGMG";

        /// <summary>
        /// RCVER3.
        /// </summary>
        public const string RCVER3 = "RCVER3";

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
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B571";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCADCN", "RCADCN", JdeDataType.Numeric, null, true, true),
        new JdeField("RCUSR0", "RCUSR0", JdeDataType.String, 20),
        new JdeField("RCVER", "RCVER", JdeDataType.String, 20),
        new JdeField("RCDEJ", "RCDEJ", JdeDataType.Numeric),
        new JdeField("RCTENT", "RCTENT", JdeDataType.Numeric),
        new JdeField("RCICUT", "RCICUT", JdeDataType.String, 4),
        new JdeField("RCICU", "RCICU", JdeDataType.Numeric),
        new JdeField("RCDBST", "RCDBST", JdeDataType.String, 2),
        new JdeField("RCNRCV", "RCNRCV", JdeDataType.Numeric),
        new JdeField("RCNINV", "RCNINV", JdeDataType.Numeric),
        new JdeField("RCAG", "RCAG", JdeDataType.Numeric),
        new JdeField("RCADSA", "RCADSA", JdeDataType.Numeric),
        new JdeField("RCNAMT", "RCNAMT", JdeDataType.Numeric),
        new JdeField("RCCRCD", "RCCRCD", JdeDataType.String, 6),
        new JdeField("RCGLBA", "RCGLBA", JdeDataType.String, 16),
        new JdeField("RCAM", "RCAM", JdeDataType.String, 2),
        new JdeField("RCDGJ", "RCDGJ", JdeDataType.Numeric),
        new JdeField("RCBACF", "RCBACF", JdeDataType.String, 2),
        new JdeField("RCBACD", "RCBACD", JdeDataType.Numeric),
        new JdeField("RCBACN", "RCBACN", JdeDataType.Numeric),
        new JdeField("RCCALN", "RCCALN", JdeDataType.String, 24),
        new JdeField("RCDDPR", "RCDDPR", JdeDataType.String, 2),
        new JdeField("RCDCDJ", "RCDCDJ", JdeDataType.Numeric),
        new JdeField("RCPSJE", "RCPSJE", JdeDataType.String, 2),
        new JdeField("RCPGM", "RCPGM", JdeDataType.String, 20),
        new JdeField("RCVER2", "RCVER2", JdeDataType.String, 20),
        new JdeField("RCCYMD", "RCCYMD", JdeDataType.String, 2),
        new JdeField("RCPGMG", "RCPGMG", JdeDataType.String, 20),
        new JdeField("RCVER3", "RCVER3", JdeDataType.String, 20),
        new JdeField("RCTORG", "RCTORG", JdeDataType.String, 20),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B571_0", "Primary Key on RCADCN", new[] { "RCADCN" }, isUnique: true, isPrimaryKey: true)
    };
}
