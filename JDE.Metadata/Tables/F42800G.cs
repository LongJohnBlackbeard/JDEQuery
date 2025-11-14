using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42800G - .
/// </summary>
public class F42800G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGBDID.
        /// </summary>
        public const string SGBDID = "SGBDID";

        /// <summary>
        /// SGGBJN.
        /// </summary>
        public const string SGGBJN = "SGGBJN";

        /// <summary>
        /// SGICU.
        /// </summary>
        public const string SGICU = "SGICU";

        /// <summary>
        /// SGICUT.
        /// </summary>
        public const string SGICUT = "SGICUT";

        /// <summary>
        /// SGIST.
        /// </summary>
        public const string SGIST = "SGIST";

        /// <summary>
        /// SGDACN.
        /// </summary>
        public const string SGDACN = "SGDACN";

        /// <summary>
        /// SGEIFL.
        /// </summary>
        public const string SGEIFL = "SGEIFL";

        /// <summary>
        /// SGUKERRO.
        /// </summary>
        public const string SGUKERRO = "SGUKERRO";

        /// <summary>
        /// SGGBTF.
        /// </summary>
        public const string SGGBTF = "SGGBTF";

        /// <summary>
        /// SGLLNM.
        /// </summary>
        public const string SGLLNM = "SGLLNM";

        /// <summary>
        /// SGKCO.
        /// </summary>
        public const string SGKCO = "SGKCO";

        /// <summary>
        /// SGDCT.
        /// </summary>
        public const string SGDCT = "SGDCT";

        /// <summary>
        /// SGDOCGB.
        /// </summary>
        public const string SGDOCGB = "SGDOCGB";

        /// <summary>
        /// SGDGL.
        /// </summary>
        public const string SGDGL = "SGDGL";

        /// <summary>
        /// SGLT.
        /// </summary>
        public const string SGLT = "SGLT";

        /// <summary>
        /// SGDICJ.
        /// </summary>
        public const string SGDICJ = "SGDICJ";

        /// <summary>
        /// SGDSYJ.
        /// </summary>
        public const string SGDSYJ = "SGDSYJ";

        /// <summary>
        /// SGTICU.
        /// </summary>
        public const string SGTICU = "SGTICU";

        /// <summary>
        /// SGCRCD.
        /// </summary>
        public const string SGCRCD = "SGCRCD";

        /// <summary>
        /// SGCRR.
        /// </summary>
        public const string SGCRR = "SGCRR";

        /// <summary>
        /// SGEXA.
        /// </summary>
        public const string SGEXA = "SGEXA";

        /// <summary>
        /// SGR1.
        /// </summary>
        public const string SGR1 = "SGR1";

        /// <summary>
        /// SGHMCU.
        /// </summary>
        public const string SGHMCU = "SGHMCU";

        /// <summary>
        /// SGGINV.
        /// </summary>
        public const string SGGINV = "SGGINV";

        /// <summary>
        /// SGIVD.
        /// </summary>
        public const string SGIVD = "SGIVD";

        /// <summary>
        /// SGRE.
        /// </summary>
        public const string SGRE = "SGRE";

        /// <summary>
        /// SGHDGJ.
        /// </summary>
        public const string SGHDGJ = "SGHDGJ";

        /// <summary>
        /// SGCRRM.
        /// </summary>
        public const string SGCRRM = "SGCRRM";

        /// <summary>
        /// SGCRDC.
        /// </summary>
        public const string SGCRDC = "SGCRDC";

        /// <summary>
        /// SGDOT1.
        /// </summary>
        public const string SGDOT1 = "SGDOT1";

        /// <summary>
        /// SGATAD.
        /// </summary>
        public const string SGATAD = "SGATAD";

        /// <summary>
        /// SGCTAD.
        /// </summary>
        public const string SGCTAD = "SGCTAD";

        /// <summary>
        /// SGCRYR.
        /// </summary>
        public const string SGCRYR = "SGCRYR";

        /// <summary>
        /// SGHCFL.
        /// </summary>
        public const string SGHCFL = "SGHCFL";

        /// <summary>
        /// SGMDFL.
        /// </summary>
        public const string SGMDFL = "SGMDFL";

        /// <summary>
        /// SGJEVER.
        /// </summary>
        public const string SGJEVER = "SGJEVER";

        /// <summary>
        /// SGERDFL.
        /// </summary>
        public const string SGERDFL = "SGERDFL";

        /// <summary>
        /// SGPYIN.
        /// </summary>
        public const string SGPYIN = "SGPYIN";

        /// <summary>
        /// SGCHTT.
        /// </summary>
        public const string SGCHTT = "SGCHTT";

        /// <summary>
        /// SGCO.
        /// </summary>
        public const string SGCO = "SGCO";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";

        /// <summary>
        /// SGTDAY.
        /// </summary>
        public const string SGTDAY = "SGTDAY";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGHCRR.
        /// </summary>
        public const string SGHCRR = "SGHCRR";
    }

    /// <inheritdoc />
    public override string TableName => "F42800G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGBDID", "SGBDID", JdeDataType.Numeric, null, true, true),
        new JdeField("SGGBJN", "SGGBJN", JdeDataType.Numeric, null, true, true),
        new JdeField("SGICU", "SGICU", JdeDataType.Numeric),
        new JdeField("SGICUT", "SGICUT", JdeDataType.String, 4),
        new JdeField("SGIST", "SGIST", JdeDataType.String, 2),
        new JdeField("SGDACN", "SGDACN", JdeDataType.String, 2),
        new JdeField("SGEIFL", "SGEIFL", JdeDataType.String, 2),
        new JdeField("SGUKERRO", "SGUKERRO", JdeDataType.String, 2),
        new JdeField("SGGBTF", "SGGBTF", JdeDataType.String, 2),
        new JdeField("SGLLNM", "SGLLNM", JdeDataType.Numeric),
        new JdeField("SGKCO", "SGKCO", JdeDataType.String, 10),
        new JdeField("SGDCT", "SGDCT", JdeDataType.String, 4),
        new JdeField("SGDOCGB", "SGDOCGB", JdeDataType.Numeric),
        new JdeField("SGDGL", "SGDGL", JdeDataType.Numeric),
        new JdeField("SGLT", "SGLT", JdeDataType.String, 4),
        new JdeField("SGDICJ", "SGDICJ", JdeDataType.Numeric),
        new JdeField("SGDSYJ", "SGDSYJ", JdeDataType.Numeric),
        new JdeField("SGTICU", "SGTICU", JdeDataType.Numeric),
        new JdeField("SGCRCD", "SGCRCD", JdeDataType.String, 6),
        new JdeField("SGCRR", "SGCRR", JdeDataType.Numeric),
        new JdeField("SGEXA", "SGEXA", JdeDataType.String, 60),
        new JdeField("SGR1", "SGR1", JdeDataType.String, 16),
        new JdeField("SGHMCU", "SGHMCU", JdeDataType.String, 24),
        new JdeField("SGGINV", "SGGINV", JdeDataType.String, 50),
        new JdeField("SGIVD", "SGIVD", JdeDataType.Numeric),
        new JdeField("SGRE", "SGRE", JdeDataType.String, 2),
        new JdeField("SGHDGJ", "SGHDGJ", JdeDataType.Numeric),
        new JdeField("SGCRRM", "SGCRRM", JdeDataType.String, 2),
        new JdeField("SGCRDC", "SGCRDC", JdeDataType.String, 6),
        new JdeField("SGDOT1", "SGDOT1", JdeDataType.String, 2),
        new JdeField("SGATAD", "SGATAD", JdeDataType.Numeric),
        new JdeField("SGCTAD", "SGCTAD", JdeDataType.Numeric),
        new JdeField("SGCRYR", "SGCRYR", JdeDataType.String, 2),
        new JdeField("SGHCFL", "SGHCFL", JdeDataType.String, 2),
        new JdeField("SGMDFL", "SGMDFL", JdeDataType.String, 2),
        new JdeField("SGJEVER", "SGJEVER", JdeDataType.String, 20),
        new JdeField("SGERDFL", "SGERDFL", JdeDataType.String, 2),
        new JdeField("SGPYIN", "SGPYIN", JdeDataType.String, 2),
        new JdeField("SGCHTT", "SGCHTT", JdeDataType.String, 2),
        new JdeField("SGCO", "SGCO", JdeDataType.String, 10),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric),
        new JdeField("SGTDAY", "SGTDAY", JdeDataType.Numeric),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGHCRR", "SGHCRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42800G_0", "Primary Key on SGBDID, SGGBJN", new[] { "SGBDID", "SGGBJN" }, isUnique: true, isPrimaryKey: true)
    };
}
