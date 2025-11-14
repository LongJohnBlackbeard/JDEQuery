using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M573 - .
/// </summary>
public class F76M573 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDHDC.
        /// </summary>
        public const string WDHDC = "WDHDC";

        /// <summary>
        /// WDCKC.
        /// </summary>
        public const string WDCKC = "WDCKC";

        /// <summary>
        /// WDRC.
        /// </summary>
        public const string WDRC = "WDRC";

        /// <summary>
        /// WDKCO.
        /// </summary>
        public const string WDKCO = "WDKCO";

        /// <summary>
        /// WDDOC.
        /// </summary>
        public const string WDDOC = "WDDOC";

        /// <summary>
        /// WDDCT.
        /// </summary>
        public const string WDDCT = "WDDCT";

        /// <summary>
        /// WDSFX.
        /// </summary>
        public const string WDSFX = "WDSFX";

        /// <summary>
        /// WDSFXE.
        /// </summary>
        public const string WDSFXE = "WDSFXE";

        /// <summary>
        /// WDM76WHTP.
        /// </summary>
        public const string WDM76WHTP = "WDM76WHTP";

        /// <summary>
        /// WDM76WPER.
        /// </summary>
        public const string WDM76WPER = "WDM76WPER";

        /// <summary>
        /// WDAA.
        /// </summary>
        public const string WDAA = "WDAA";

        /// <summary>
        /// WDACR.
        /// </summary>
        public const string WDACR = "WDACR";

        /// <summary>
        /// WDM76GORT.
        /// </summary>
        public const string WDM76GORT = "WDM76GORT";

        /// <summary>
        /// WDM76WCON.
        /// </summary>
        public const string WDM76WCON = "WDM76WCON";

        /// <summary>
        /// WDM76FDAT.
        /// </summary>
        public const string WDM76FDAT = "WDM76FDAT";

        /// <summary>
        /// WDM76FFLG.
        /// </summary>
        public const string WDM76FFLG = "WDM76FFLG";

        /// <summary>
        /// WDM76FNUM.
        /// </summary>
        public const string WDM76FNUM = "WDM76FNUM";

        /// <summary>
        /// WDM76FSTR.
        /// </summary>
        public const string WDM76FSTR = "WDM76FSTR";

        /// <summary>
        /// WDUSER.
        /// </summary>
        public const string WDUSER = "WDUSER";

        /// <summary>
        /// WDPID.
        /// </summary>
        public const string WDPID = "WDPID";

        /// <summary>
        /// WDJOBN.
        /// </summary>
        public const string WDJOBN = "WDJOBN";

        /// <summary>
        /// WDUPMJ.
        /// </summary>
        public const string WDUPMJ = "WDUPMJ";

        /// <summary>
        /// WDUPMT.
        /// </summary>
        public const string WDUPMT = "WDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDHDC", "WDHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("WDCKC", "WDCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("WDRC", "WDRC", JdeDataType.String, 2, true, true),
        new JdeField("WDKCO", "WDKCO", JdeDataType.String, 10, true, true),
        new JdeField("WDDOC", "WDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WDDCT", "WDDCT", JdeDataType.String, 4, true, true),
        new JdeField("WDSFX", "WDSFX", JdeDataType.String, 6, true, true),
        new JdeField("WDSFXE", "WDSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("WDM76WHTP", "WDM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("WDM76WPER", "WDM76WPER", JdeDataType.Numeric),
        new JdeField("WDAA", "WDAA", JdeDataType.Numeric),
        new JdeField("WDACR", "WDACR", JdeDataType.Numeric),
        new JdeField("WDM76GORT", "WDM76GORT", JdeDataType.String, 2),
        new JdeField("WDM76WCON", "WDM76WCON", JdeDataType.String, 6),
        new JdeField("WDM76FDAT", "WDM76FDAT", JdeDataType.Numeric),
        new JdeField("WDM76FFLG", "WDM76FFLG", JdeDataType.String, 2),
        new JdeField("WDM76FNUM", "WDM76FNUM", JdeDataType.Numeric),
        new JdeField("WDM76FSTR", "WDM76FSTR", JdeDataType.String, 60),
        new JdeField("WDUSER", "WDUSER", JdeDataType.String, 20),
        new JdeField("WDPID", "WDPID", JdeDataType.String, 20),
        new JdeField("WDJOBN", "WDJOBN", JdeDataType.String, 20),
        new JdeField("WDUPMJ", "WDUPMJ", JdeDataType.Numeric),
        new JdeField("WDUPMT", "WDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M573_0", "Primary Key on WDHDC, WDCKC, WDRC, WDKCO, WDDOC, WDDCT, WDSFX, WDSFXE, WDM76WHTP", new[] { "WDHDC", "WDCKC", "WDRC", "WDKCO", "WDDOC", "WDDCT", "WDSFX", "WDSFXE", "WDM76WHTP" }, isUnique: true, isPrimaryKey: true)
    };
}
