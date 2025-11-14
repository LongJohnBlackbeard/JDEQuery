using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3905 - .
/// </summary>
public class F3905 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVSVVM.
        /// </summary>
        public const string SVSVVM = "SVSVVM";

        /// <summary>
        /// SVDSC1.
        /// </summary>
        public const string SVDSC1 = "SVDSC1";

        /// <summary>
        /// SVVLTY.
        /// </summary>
        public const string SVVLTY = "SVVLTY";

        /// <summary>
        /// SVSORD.
        /// </summary>
        public const string SVSORD = "SVSORD";

        /// <summary>
        /// SVWBOC.
        /// </summary>
        public const string SVWBOC = "SVWBOC";

        /// <summary>
        /// SVINAC.
        /// </summary>
        public const string SVINAC = "SVINAC";

        /// <summary>
        /// SVITRA.
        /// </summary>
        public const string SVITRA = "SVITRA";

        /// <summary>
        /// SVINNS.
        /// </summary>
        public const string SVINNS = "SVINNS";

        /// <summary>
        /// SVLIFA.
        /// </summary>
        public const string SVLIFA = "SVLIFA";

        /// <summary>
        /// SVBFNN.
        /// </summary>
        public const string SVBFNN = "SVBFNN";

        /// <summary>
        /// SVBFNU.
        /// </summary>
        public const string SVBFNU = "SVBFNU";

        /// <summary>
        /// SVSVCE.
        /// </summary>
        public const string SVSVCE = "SVSVCE";

        /// <summary>
        /// SVSVDT.
        /// </summary>
        public const string SVSVDT = "SVSVDT";

        /// <summary>
        /// SVSVFU.
        /// </summary>
        public const string SVSVFU = "SVSVFU";

        /// <summary>
        /// SVSVF1.
        /// </summary>
        public const string SVSVF1 = "SVSVF1";

        /// <summary>
        /// SVSVF2.
        /// </summary>
        public const string SVSVF2 = "SVSVF2";

        /// <summary>
        /// SVSVF3.
        /// </summary>
        public const string SVSVF3 = "SVSVF3";

        /// <summary>
        /// SVSVF4.
        /// </summary>
        public const string SVSVF4 = "SVSVF4";

        /// <summary>
        /// SVSVF5.
        /// </summary>
        public const string SVSVF5 = "SVSVF5";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVTDAY.
        /// </summary>
        public const string SVTDAY = "SVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3905";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVSVVM", "SVSVVM", JdeDataType.String, 4, true, true),
        new JdeField("SVDSC1", "SVDSC1", JdeDataType.String, 60),
        new JdeField("SVVLTY", "SVVLTY", JdeDataType.String, 2),
        new JdeField("SVSORD", "SVSORD", JdeDataType.String, 2),
        new JdeField("SVWBOC", "SVWBOC", JdeDataType.String, 2),
        new JdeField("SVINAC", "SVINAC", JdeDataType.String, 2),
        new JdeField("SVITRA", "SVITRA", JdeDataType.String, 2),
        new JdeField("SVINNS", "SVINNS", JdeDataType.String, 2),
        new JdeField("SVLIFA", "SVLIFA", JdeDataType.String, 2),
        new JdeField("SVBFNN", "SVBFNN", JdeDataType.String, 60),
        new JdeField("SVBFNU", "SVBFNU", JdeDataType.String, 60),
        new JdeField("SVSVCE", "SVSVCE", JdeDataType.String, 4),
        new JdeField("SVSVDT", "SVSVDT", JdeDataType.Numeric),
        new JdeField("SVSVFU", "SVSVFU", JdeDataType.String, 4),
        new JdeField("SVSVF1", "SVSVF1", JdeDataType.String, 2),
        new JdeField("SVSVF2", "SVSVF2", JdeDataType.String, 2),
        new JdeField("SVSVF3", "SVSVF3", JdeDataType.String, 2),
        new JdeField("SVSVF4", "SVSVF4", JdeDataType.String, 2),
        new JdeField("SVSVF5", "SVSVF5", JdeDataType.String, 2),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVTDAY", "SVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3905_0", "Primary Key on SVSVVM", new[] { "SVSVVM" }, isUnique: true, isPrimaryKey: true)
    };
}
