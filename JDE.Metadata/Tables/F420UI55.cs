using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F420UI55 - .
/// </summary>
public class F420UI55 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UISNKY.
        /// </summary>
        public const string UISNKY = "UISNKY";

        /// <summary>
        /// UIKITID.
        /// </summary>
        public const string UIKITID = "UIKITID";

        /// <summary>
        /// UIDOCO.
        /// </summary>
        public const string UIDOCO = "UIDOCO";

        /// <summary>
        /// UIDCTO.
        /// </summary>
        public const string UIDCTO = "UIDCTO";

        /// <summary>
        /// UIKCOO.
        /// </summary>
        public const string UIKCOO = "UIKCOO";

        /// <summary>
        /// UILNID.
        /// </summary>
        public const string UILNID = "UILNID";

        /// <summary>
        /// UIUITM.
        /// </summary>
        public const string UIUITM = "UIUITM";

        /// <summary>
        /// UIDSC1.
        /// </summary>
        public const string UIDSC1 = "UIDSC1";

        /// <summary>
        /// UIMCU.
        /// </summary>
        public const string UIMCU = "UIMCU";

        /// <summary>
        /// UILOCN.
        /// </summary>
        public const string UILOCN = "UILOCN";

        /// <summary>
        /// UILOTN.
        /// </summary>
        public const string UILOTN = "UILOTN";

        /// <summary>
        /// UIUORG.
        /// </summary>
        public const string UIUORG = "UIUORG";

        /// <summary>
        /// UISOQS.
        /// </summary>
        public const string UISOQS = "UISOQS";

        /// <summary>
        /// UISOBK.
        /// </summary>
        public const string UISOBK = "UISOBK";

        /// <summary>
        /// UISOCN.
        /// </summary>
        public const string UISOCN = "UISOCN";

        /// <summary>
        /// UIUOM.
        /// </summary>
        public const string UIUOM = "UIUOM";

        /// <summary>
        /// UIQRLV.
        /// </summary>
        public const string UIQRLV = "UIQRLV";

        /// <summary>
        /// UISOQS2.
        /// </summary>
        public const string UISOQS2 = "UISOQS2";

        /// <summary>
        /// UIUOM2.
        /// </summary>
        public const string UIUOM2 = "UIUOM2";

        /// <summary>
        /// UIQRLV2.
        /// </summary>
        public const string UIQRLV2 = "UIQRLV2";

        /// <summary>
        /// UISSOQS2.
        /// </summary>
        public const string UISSOQS2 = "UISSOQS2";

        /// <summary>
        /// UISOBK2.
        /// </summary>
        public const string UISOBK2 = "UISOBK2";

        /// <summary>
        /// UISSOBK2.
        /// </summary>
        public const string UISSOBK2 = "UISSOBK2";

        /// <summary>
        /// UISOCN2.
        /// </summary>
        public const string UISOCN2 = "UISOCN2";

        /// <summary>
        /// UIJOBS.
        /// </summary>
        public const string UIJOBS = "UIJOBS";

        /// <summary>
        /// UIRLOT.
        /// </summary>
        public const string UIRLOT = "UIRLOT";

        /// <summary>
        /// UILOT1.
        /// </summary>
        public const string UILOT1 = "UILOT1";

        /// <summary>
        /// UILOT2.
        /// </summary>
        public const string UILOT2 = "UILOT2";

        /// <summary>
        /// UIMMEJ.
        /// </summary>
        public const string UIMMEJ = "UIMMEJ";

        /// <summary>
        /// UIDLEJ.
        /// </summary>
        public const string UIDLEJ = "UIDLEJ";

        /// <summary>
        /// UIKTLN.
        /// </summary>
        public const string UIKTLN = "UIKTLN";

        /// <summary>
        /// UIPELC.
        /// </summary>
        public const string UIPELC = "UIPELC";

        /// <summary>
        /// UIORIG.
        /// </summary>
        public const string UIORIG = "UIORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F420UI55";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UISNKY", "UISNKY", JdeDataType.String, 64, true, true),
        new JdeField("UIKITID", "UIKITID", JdeDataType.Numeric, null, true, true),
        new JdeField("UIDOCO", "UIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("UIDCTO", "UIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("UIKCOO", "UIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("UILNID", "UILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("UIUITM", "UIUITM", JdeDataType.String, 52),
        new JdeField("UIDSC1", "UIDSC1", JdeDataType.String, 60),
        new JdeField("UIMCU", "UIMCU", JdeDataType.String, 24),
        new JdeField("UILOCN", "UILOCN", JdeDataType.String, 40),
        new JdeField("UILOTN", "UILOTN", JdeDataType.String, 60),
        new JdeField("UIUORG", "UIUORG", JdeDataType.Numeric),
        new JdeField("UISOQS", "UISOQS", JdeDataType.Numeric),
        new JdeField("UISOBK", "UISOBK", JdeDataType.Numeric),
        new JdeField("UISOCN", "UISOCN", JdeDataType.Numeric),
        new JdeField("UIUOM", "UIUOM", JdeDataType.String, 4),
        new JdeField("UIQRLV", "UIQRLV", JdeDataType.Numeric),
        new JdeField("UISOQS2", "UISOQS2", JdeDataType.Numeric),
        new JdeField("UIUOM2", "UIUOM2", JdeDataType.String, 4),
        new JdeField("UIQRLV2", "UIQRLV2", JdeDataType.Numeric),
        new JdeField("UISSOQS2", "UISSOQS2", JdeDataType.Numeric),
        new JdeField("UISOBK2", "UISOBK2", JdeDataType.Numeric),
        new JdeField("UISSOBK2", "UISSOBK2", JdeDataType.Numeric),
        new JdeField("UISOCN2", "UISOCN2", JdeDataType.Numeric),
        new JdeField("UIJOBS", "UIJOBS", JdeDataType.Numeric),
        new JdeField("UIRLOT", "UIRLOT", JdeDataType.String, 60),
        new JdeField("UILOT1", "UILOT1", JdeDataType.String, 60),
        new JdeField("UILOT2", "UILOT2", JdeDataType.String, 60),
        new JdeField("UIMMEJ", "UIMMEJ", JdeDataType.Numeric),
        new JdeField("UIDLEJ", "UIDLEJ", JdeDataType.Numeric),
        new JdeField("UIKTLN", "UIKTLN", JdeDataType.Numeric),
        new JdeField("UIPELC", "UIPELC", JdeDataType.String, 2),
        new JdeField("UIORIG", "UIORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F420UI55_0", "Primary Key on UISNKY, UIKITID, UIDOCO, UIDCTO, UIKCOO, UILNID", new[] { "UISNKY", "UIKITID", "UIDOCO", "UIDCTO", "UIKCOO", "UILNID" }, isUnique: true, isPrimaryKey: true)
    };
}
