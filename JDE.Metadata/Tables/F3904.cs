using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3904 - .
/// </summary>
public class F3904 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLCO.
        /// </summary>
        public const string PLCO = "PLCO";

        /// <summary>
        /// PLITPL.
        /// </summary>
        public const string PLITPL = "PLITPL";

        /// <summary>
        /// PLITM.
        /// </summary>
        public const string PLITM = "PLITM";

        /// <summary>
        /// PLSVVM.
        /// </summary>
        public const string PLSVVM = "PLSVVM";

        /// <summary>
        /// PLSVDC.
        /// </summary>
        public const string PLSVDC = "PLSVDC";

        /// <summary>
        /// PLCSMT.
        /// </summary>
        public const string PLCSMT = "PLCSMT";

        /// <summary>
        /// PLSVDT.
        /// </summary>
        public const string PLSVDT = "PLSVDT";

        /// <summary>
        /// PLSVFU.
        /// </summary>
        public const string PLSVFU = "PLSVFU";

        /// <summary>
        /// PLSVF1.
        /// </summary>
        public const string PLSVF1 = "PLSVF1";

        /// <summary>
        /// PLSVF2.
        /// </summary>
        public const string PLSVF2 = "PLSVF2";

        /// <summary>
        /// PLSVF3.
        /// </summary>
        public const string PLSVF3 = "PLSVF3";

        /// <summary>
        /// PLSVF4.
        /// </summary>
        public const string PLSVF4 = "PLSVF4";

        /// <summary>
        /// PLSVF5.
        /// </summary>
        public const string PLSVF5 = "PLSVF5";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLTDAY.
        /// </summary>
        public const string PLTDAY = "PLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3904";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLCO", "PLCO", JdeDataType.String, 10, true, true),
        new JdeField("PLITPL", "PLITPL", JdeDataType.String, 20, true, true),
        new JdeField("PLITM", "PLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PLSVVM", "PLSVVM", JdeDataType.String, 4, true, true),
        new JdeField("PLSVDC", "PLSVDC", JdeDataType.String, 2),
        new JdeField("PLCSMT", "PLCSMT", JdeDataType.String, 4),
        new JdeField("PLSVDT", "PLSVDT", JdeDataType.Numeric),
        new JdeField("PLSVFU", "PLSVFU", JdeDataType.String, 4),
        new JdeField("PLSVF1", "PLSVF1", JdeDataType.String, 2),
        new JdeField("PLSVF2", "PLSVF2", JdeDataType.String, 2),
        new JdeField("PLSVF3", "PLSVF3", JdeDataType.String, 2),
        new JdeField("PLSVF4", "PLSVF4", JdeDataType.String, 2),
        new JdeField("PLSVF5", "PLSVF5", JdeDataType.String, 2),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLTDAY", "PLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3904_0", "Primary Key on PLCO, PLITPL, PLITM, PLSVVM", new[] { "PLCO", "PLITPL", "PLITM", "PLSVVM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3904_2", "Index on PLCO, PLITPL, PLITM", new[] { "PLCO", "PLITPL", "PLITM" })
    };
}
