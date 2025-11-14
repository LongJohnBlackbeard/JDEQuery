using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08360 - .
/// </summary>
public class F08360 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HETSTN.
        /// </summary>
        public const string HETSTN = "HETSTN";

        /// <summary>
        /// HETSTY.
        /// </summary>
        public const string HETSTY = "HETSTY";

        /// <summary>
        /// HEAN8.
        /// </summary>
        public const string HEAN8 = "HEAN8";

        /// <summary>
        /// HEHMCO.
        /// </summary>
        public const string HEHMCO = "HEHMCO";

        /// <summary>
        /// HETAXX.
        /// </summary>
        public const string HETAXX = "HETAXX";

        /// <summary>
        /// HESSN.
        /// </summary>
        public const string HESSN = "HESSN";

        /// <summary>
        /// HEKEYE.
        /// </summary>
        public const string HEKEYE = "HEKEYE";

        /// <summary>
        /// HEOFCF.
        /// </summary>
        public const string HEOFCF = "HEOFCF";

        /// <summary>
        /// HESOWN.
        /// </summary>
        public const string HESOWN = "HESOWN";

        /// <summary>
        /// HESOA.
        /// </summary>
        public const string HESOA = "HESOA";

        /// <summary>
        /// HEADP.
        /// </summary>
        public const string HEADP = "HEADP";

        /// <summary>
        /// HEACP.
        /// </summary>
        public const string HEACP = "HEACP";

        /// <summary>
        /// HEERNK.
        /// </summary>
        public const string HEERNK = "HEERNK";

        /// <summary>
        /// HEADPR.
        /// </summary>
        public const string HEADPR = "HEADPR";

        /// <summary>
        /// HEACPK.
        /// </summary>
        public const string HEACPK = "HEACPK";

        /// <summary>
        /// HEAPTG.
        /// </summary>
        public const string HEAPTG = "HEAPTG";

        /// <summary>
        /// HEAPTB.
        /// </summary>
        public const string HEAPTB = "HEAPTB";

        /// <summary>
        /// HETCMP.
        /// </summary>
        public const string HETCMP = "HETCMP";

        /// <summary>
        /// HEEECO.
        /// </summary>
        public const string HEEECO = "HEEECO";

        /// <summary>
        /// HEERCO.
        /// </summary>
        public const string HEERCO = "HEERCO";

        /// <summary>
        /// HERAP.
        /// </summary>
        public const string HERAP = "HERAP";

        /// <summary>
        /// HEEFTB.
        /// </summary>
        public const string HEEFTB = "HEEFTB";

        /// <summary>
        /// HEEFTE.
        /// </summary>
        public const string HEEFTE = "HEEFTE";

        /// <summary>
        /// HECKCN.
        /// </summary>
        public const string HECKCN = "HECKCN";

        /// <summary>
        /// HENPAY.
        /// </summary>
        public const string HENPAY = "HENPAY";

        /// <summary>
        /// HEDOCM.
        /// </summary>
        public const string HEDOCM = "HEDOCM";

        /// <summary>
        /// HECKDT.
        /// </summary>
        public const string HECKDT = "HECKDT";

        /// <summary>
        /// HEPDBA.
        /// </summary>
        public const string HEPDBA = "HEPDBA";

        /// <summary>
        /// HEICC.
        /// </summary>
        public const string HEICC = "HEICC";

        /// <summary>
        /// HEICS.
        /// </summary>
        public const string HEICS = "HEICS";

        /// <summary>
        /// HEHCEU.
        /// </summary>
        public const string HEHCEU = "HEHCEU";
    }

    /// <inheritdoc />
    public override string TableName => "F08360";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HETSTN", "HETSTN", JdeDataType.String, 16, true, true),
        new JdeField("HETSTY", "HETSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HEAN8", "HEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HEHMCO", "HEHMCO", JdeDataType.String, 10, true, true),
        new JdeField("HETAXX", "HETAXX", JdeDataType.String, 40),
        new JdeField("HESSN", "HESSN", JdeDataType.String, 40),
        new JdeField("HEKEYE", "HEKEYE", JdeDataType.String, 2, true, true),
        new JdeField("HEOFCF", "HEOFCF", JdeDataType.String, 2),
        new JdeField("HESOWN", "HESOWN", JdeDataType.String, 2),
        new JdeField("HESOA", "HESOA", JdeDataType.Numeric),
        new JdeField("HEADP", "HEADP", JdeDataType.Numeric),
        new JdeField("HEACP", "HEACP", JdeDataType.Numeric),
        new JdeField("HEERNK", "HEERNK", JdeDataType.Numeric),
        new JdeField("HEADPR", "HEADPR", JdeDataType.Numeric),
        new JdeField("HEACPK", "HEACPK", JdeDataType.Numeric),
        new JdeField("HEAPTG", "HEAPTG", JdeDataType.Numeric),
        new JdeField("HEAPTB", "HEAPTB", JdeDataType.Numeric),
        new JdeField("HETCMP", "HETCMP", JdeDataType.Numeric),
        new JdeField("HEEECO", "HEEECO", JdeDataType.Numeric),
        new JdeField("HEERCO", "HEERCO", JdeDataType.Numeric),
        new JdeField("HERAP", "HERAP", JdeDataType.Numeric),
        new JdeField("HEEFTB", "HEEFTB", JdeDataType.Numeric),
        new JdeField("HEEFTE", "HEEFTE", JdeDataType.Numeric),
        new JdeField("HECKCN", "HECKCN", JdeDataType.Numeric),
        new JdeField("HENPAY", "HENPAY", JdeDataType.Numeric),
        new JdeField("HEDOCM", "HEDOCM", JdeDataType.Numeric),
        new JdeField("HECKDT", "HECKDT", JdeDataType.Numeric),
        new JdeField("HEPDBA", "HEPDBA", JdeDataType.Numeric),
        new JdeField("HEICC", "HEICC", JdeDataType.String, 2),
        new JdeField("HEICS", "HEICS", JdeDataType.String, 2),
        new JdeField("HEHCEU", "HEHCEU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08360_0", "Primary Key on HETSTN, HETSTY, HEAN8, HEHMCO, HEKEYE", new[] { "HETSTN", "HETSTY", "HEAN8", "HEHMCO", "HEKEYE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08360_2", "Index on HETSTN, HETSTY, SYS_NC00032$, SYS_NC00033$", new[] { "HETSTN", "HETSTY", "SYS_NC00032$", "SYS_NC00033$" }),
        new JdeIndex("F08360_3", "Index on HETSTN, HETSTY, SYS_NC00034$, SYS_NC00035$", new[] { "HETSTN", "HETSTY", "SYS_NC00034$", "SYS_NC00035$" }),
        new JdeIndex("F08360_4", "Index on HETSTN, HETSTY, SYS_NC00036$, SYS_NC00035$", new[] { "HETSTN", "HETSTY", "SYS_NC00036$", "SYS_NC00035$" }),
        new JdeIndex("F08360_5", "Index on HETSTN, HETSTY, HEAN8", new[] { "HETSTN", "HETSTY", "HEAN8" }),
        new JdeIndex("F08360_6", "Index on HETSTN, HETSTY, SYS_NC00032$", new[] { "HETSTN", "HETSTY", "SYS_NC00032$" }),
        new JdeIndex("F08360_7", "Index on HEAN8", new[] { "HEAN8" })
    };
}
