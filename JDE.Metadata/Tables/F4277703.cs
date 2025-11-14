using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277703 - .
/// </summary>
public class F4277703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UIJOBS.
        /// </summary>
        public const string UIJOBS = "UIJOBS";

        /// <summary>
        /// UIUKID.
        /// </summary>
        public const string UIUKID = "UIUKID";

        /// <summary>
        /// UIITM.
        /// </summary>
        public const string UIITM = "UIITM";

        /// <summary>
        /// UIMCU.
        /// </summary>
        public const string UIMCU = "UIMCU";

        /// <summary>
        /// UILITM.
        /// </summary>
        public const string UILITM = "UILITM";

        /// <summary>
        /// UIDSC1.
        /// </summary>
        public const string UIDSC1 = "UIDSC1";

        /// <summary>
        /// UIUFULQTY.
        /// </summary>
        public const string UIUFULQTY = "UIUFULQTY";

        /// <summary>
        /// UISUFULQTY.
        /// </summary>
        public const string UISUFULQTY = "UISUFULQTY";

        /// <summary>
        /// UIUOM1.
        /// </summary>
        public const string UIUOM1 = "UIUOM1";

        /// <summary>
        /// UIUOM2.
        /// </summary>
        public const string UIUOM2 = "UIUOM2";

        /// <summary>
        /// UIPQOH.
        /// </summary>
        public const string UIPQOH = "UIPQOH";

        /// <summary>
        /// UISQOH.
        /// </summary>
        public const string UISQOH = "UISQOH";

        /// <summary>
        /// UIQAVAL.
        /// </summary>
        public const string UIQAVAL = "UIQAVAL";

        /// <summary>
        /// UISAVAL.
        /// </summary>
        public const string UISAVAL = "UISAVAL";

        /// <summary>
        /// UISAFE.
        /// </summary>
        public const string UISAFE = "UISAFE";

        /// <summary>
        /// UIUFULERR.
        /// </summary>
        public const string UIUFULERR = "UIUFULERR";

        /// <summary>
        /// UIDUAL.
        /// </summary>
        public const string UIDUAL = "UIDUAL";

        /// <summary>
        /// UIURCD.
        /// </summary>
        public const string UIURCD = "UIURCD";

        /// <summary>
        /// UIURDT.
        /// </summary>
        public const string UIURDT = "UIURDT";

        /// <summary>
        /// UIURRF.
        /// </summary>
        public const string UIURRF = "UIURRF";

        /// <summary>
        /// UIURAT.
        /// </summary>
        public const string UIURAT = "UIURAT";

        /// <summary>
        /// UIURAB.
        /// </summary>
        public const string UIURAB = "UIURAB";

        /// <summary>
        /// UIUTIME.
        /// </summary>
        public const string UIUTIME = "UIUTIME";

        /// <summary>
        /// UIKTFG.
        /// </summary>
        public const string UIKTFG = "UIKTFG";

        /// <summary>
        /// UIDPPO.
        /// </summary>
        public const string UIDPPO = "UIDPPO";

        /// <summary>
        /// UIQTYONOR.
        /// </summary>
        public const string UIQTYONOR = "UIQTYONOR";
    }

    /// <inheritdoc />
    public override string TableName => "F4277703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UIJOBS", "UIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("UIUKID", "UIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("UIITM", "UIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("UIMCU", "UIMCU", JdeDataType.String, 24, true, true),
        new JdeField("UILITM", "UILITM", JdeDataType.String, 50),
        new JdeField("UIDSC1", "UIDSC1", JdeDataType.String, 60),
        new JdeField("UIUFULQTY", "UIUFULQTY", JdeDataType.Numeric),
        new JdeField("UISUFULQTY", "UISUFULQTY", JdeDataType.Numeric),
        new JdeField("UIUOM1", "UIUOM1", JdeDataType.String, 4),
        new JdeField("UIUOM2", "UIUOM2", JdeDataType.String, 4),
        new JdeField("UIPQOH", "UIPQOH", JdeDataType.Numeric),
        new JdeField("UISQOH", "UISQOH", JdeDataType.Numeric),
        new JdeField("UIQAVAL", "UIQAVAL", JdeDataType.Numeric),
        new JdeField("UISAVAL", "UISAVAL", JdeDataType.Numeric),
        new JdeField("UISAFE", "UISAFE", JdeDataType.Numeric),
        new JdeField("UIUFULERR", "UIUFULERR", JdeDataType.String, 20),
        new JdeField("UIDUAL", "UIDUAL", JdeDataType.String, 2),
        new JdeField("UIURCD", "UIURCD", JdeDataType.String, 4),
        new JdeField("UIURDT", "UIURDT", JdeDataType.Numeric),
        new JdeField("UIURRF", "UIURRF", JdeDataType.String, 30),
        new JdeField("UIURAT", "UIURAT", JdeDataType.Numeric),
        new JdeField("UIURAB", "UIURAB", JdeDataType.Numeric),
        new JdeField("UIUTIME", "UIUTIME", JdeDataType.Date),
        new JdeField("UIKTFG", "UIKTFG", JdeDataType.String, 2),
        new JdeField("UIDPPO", "UIDPPO", JdeDataType.String, 2),
        new JdeField("UIQTYONOR", "UIQTYONOR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277703_0", "Primary Key on UIJOBS, UIUKID, UIITM, UIMCU", new[] { "UIJOBS", "UIUKID", "UIITM", "UIMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
