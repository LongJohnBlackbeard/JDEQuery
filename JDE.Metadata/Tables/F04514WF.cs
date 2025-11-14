using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04514WF - .
/// </summary>
public class F04514WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KRST.
        /// </summary>
        public const string KRST = "KRST";

        /// <summary>
        /// KRUKID.
        /// </summary>
        public const string KRUKID = "KRUKID";

        /// <summary>
        /// KRUPDATEC.
        /// </summary>
        public const string KRUPDATEC = "KRUPDATEC";

        /// <summary>
        /// KRAAP1.
        /// </summary>
        public const string KRAAP1 = "KRAAP1";

        /// <summary>
        /// KRAAP2.
        /// </summary>
        public const string KRAAP2 = "KRAAP2";

        /// <summary>
        /// KRAAP3.
        /// </summary>
        public const string KRAAP3 = "KRAAP3";

        /// <summary>
        /// KRAAP4.
        /// </summary>
        public const string KRAAP4 = "KRAAP4";

        /// <summary>
        /// KRAAP5.
        /// </summary>
        public const string KRAAP5 = "KRAAP5";

        /// <summary>
        /// KRAAP6.
        /// </summary>
        public const string KRAAP6 = "KRAAP6";

        /// <summary>
        /// KRAAP7.
        /// </summary>
        public const string KRAAP7 = "KRAAP7";

        /// <summary>
        /// KRAAP8.
        /// </summary>
        public const string KRAAP8 = "KRAAP8";

        /// <summary>
        /// KRAAP9.
        /// </summary>
        public const string KRAAP9 = "KRAAP9";

        /// <summary>
        /// KRAAPA.
        /// </summary>
        public const string KRAAPA = "KRAAPA";

        /// <summary>
        /// KRAAPB1.
        /// </summary>
        public const string KRAAPB1 = "KRAAPB1";

        /// <summary>
        /// KRAAPC.
        /// </summary>
        public const string KRAAPC = "KRAAPC";

        /// <summary>
        /// KRAAPD.
        /// </summary>
        public const string KRAAPD = "KRAAPD";

        /// <summary>
        /// KRAAPE.
        /// </summary>
        public const string KRAAPE = "KRAAPE";

        /// <summary>
        /// KRAAPF1.
        /// </summary>
        public const string KRAAPF1 = "KRAAPF1";

        /// <summary>
        /// KRAAPG1.
        /// </summary>
        public const string KRAAPG1 = "KRAAPG1";

        /// <summary>
        /// KRAAPH1.
        /// </summary>
        public const string KRAAPH1 = "KRAAPH1";

        /// <summary>
        /// KRAAPI1.
        /// </summary>
        public const string KRAAPI1 = "KRAAPI1";

        /// <summary>
        /// KRAAPJ.
        /// </summary>
        public const string KRAAPJ = "KRAAPJ";

        /// <summary>
        /// KRAAPK.
        /// </summary>
        public const string KRAAPK = "KRAAPK";

        /// <summary>
        /// KRAAPL1.
        /// </summary>
        public const string KRAAPL1 = "KRAAPL1";

        /// <summary>
        /// KRAAPM.
        /// </summary>
        public const string KRAAPM = "KRAAPM";

        /// <summary>
        /// KRAAPN.
        /// </summary>
        public const string KRAAPN = "KRAAPN";

        /// <summary>
        /// KRAAPO1.
        /// </summary>
        public const string KRAAPO1 = "KRAAPO1";

        /// <summary>
        /// KRAAPP.
        /// </summary>
        public const string KRAAPP = "KRAAPP";
    }

    /// <inheritdoc />
    public override string TableName => "F04514WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KRST", "KRST", JdeDataType.String, 4, true, true),
        new JdeField("KRUKID", "KRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KRUPDATEC", "KRUPDATEC", JdeDataType.Numeric),
        new JdeField("KRAAP1", "KRAAP1", JdeDataType.Numeric),
        new JdeField("KRAAP2", "KRAAP2", JdeDataType.Numeric),
        new JdeField("KRAAP3", "KRAAP3", JdeDataType.Numeric),
        new JdeField("KRAAP4", "KRAAP4", JdeDataType.Numeric),
        new JdeField("KRAAP5", "KRAAP5", JdeDataType.Numeric),
        new JdeField("KRAAP6", "KRAAP6", JdeDataType.Numeric),
        new JdeField("KRAAP7", "KRAAP7", JdeDataType.Numeric),
        new JdeField("KRAAP8", "KRAAP8", JdeDataType.Numeric),
        new JdeField("KRAAP9", "KRAAP9", JdeDataType.Numeric),
        new JdeField("KRAAPA", "KRAAPA", JdeDataType.Numeric),
        new JdeField("KRAAPB1", "KRAAPB1", JdeDataType.Numeric),
        new JdeField("KRAAPC", "KRAAPC", JdeDataType.Numeric),
        new JdeField("KRAAPD", "KRAAPD", JdeDataType.Numeric),
        new JdeField("KRAAPE", "KRAAPE", JdeDataType.Numeric),
        new JdeField("KRAAPF1", "KRAAPF1", JdeDataType.Numeric),
        new JdeField("KRAAPG1", "KRAAPG1", JdeDataType.Numeric),
        new JdeField("KRAAPH1", "KRAAPH1", JdeDataType.Numeric),
        new JdeField("KRAAPI1", "KRAAPI1", JdeDataType.Numeric),
        new JdeField("KRAAPJ", "KRAAPJ", JdeDataType.Numeric),
        new JdeField("KRAAPK", "KRAAPK", JdeDataType.Numeric),
        new JdeField("KRAAPL1", "KRAAPL1", JdeDataType.Numeric),
        new JdeField("KRAAPM", "KRAAPM", JdeDataType.Numeric),
        new JdeField("KRAAPN", "KRAAPN", JdeDataType.Numeric),
        new JdeField("KRAAPO1", "KRAAPO1", JdeDataType.Numeric),
        new JdeField("KRAAPP", "KRAAPP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04514WF_0", "Primary Key on KRST, KRUKID", new[] { "KRST", "KRUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
