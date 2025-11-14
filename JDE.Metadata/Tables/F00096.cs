using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00096 - .
/// </summary>
public class F00096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M0OBNM.
        /// </summary>
        public const string M0OBNM = "M0OBNM";

        /// <summary>
        /// M0TXKY.
        /// </summary>
        public const string M0TXKY = "M0TXKY";

        /// <summary>
        /// M0MOCATCD1.
        /// </summary>
        public const string M0MOCATCD1 = "M0MOCATCD1";

        /// <summary>
        /// M0MOCATCD2.
        /// </summary>
        public const string M0MOCATCD2 = "M0MOCATCD2";

        /// <summary>
        /// M0MOCATCD3.
        /// </summary>
        public const string M0MOCATCD3 = "M0MOCATCD3";

        /// <summary>
        /// M0MOCATCD4.
        /// </summary>
        public const string M0MOCATCD4 = "M0MOCATCD4";

        /// <summary>
        /// M0MOCATCD5.
        /// </summary>
        public const string M0MOCATCD5 = "M0MOCATCD5";

        /// <summary>
        /// M0MOCATCD6.
        /// </summary>
        public const string M0MOCATCD6 = "M0MOCATCD6";

        /// <summary>
        /// M0MOCATCD7.
        /// </summary>
        public const string M0MOCATCD7 = "M0MOCATCD7";

        /// <summary>
        /// M0MOCATCD8.
        /// </summary>
        public const string M0MOCATCD8 = "M0MOCATCD8";

        /// <summary>
        /// M0MOCATCD9.
        /// </summary>
        public const string M0MOCATCD9 = "M0MOCATCD9";

        /// <summary>
        /// M0MOCATCD10.
        /// </summary>
        public const string M0MOCATCD10 = "M0MOCATCD10";

        /// <summary>
        /// M0MOCATCD11.
        /// </summary>
        public const string M0MOCATCD11 = "M0MOCATCD11";

        /// <summary>
        /// M0MOCATCD12.
        /// </summary>
        public const string M0MOCATCD12 = "M0MOCATCD12";

        /// <summary>
        /// M0MOCATCD13.
        /// </summary>
        public const string M0MOCATCD13 = "M0MOCATCD13";

        /// <summary>
        /// M0MOCATCD14.
        /// </summary>
        public const string M0MOCATCD14 = "M0MOCATCD14";

        /// <summary>
        /// M0MOCATCD15.
        /// </summary>
        public const string M0MOCATCD15 = "M0MOCATCD15";

        /// <summary>
        /// M0MOCATCD16.
        /// </summary>
        public const string M0MOCATCD16 = "M0MOCATCD16";

        /// <summary>
        /// M0MOCATCD17.
        /// </summary>
        public const string M0MOCATCD17 = "M0MOCATCD17";

        /// <summary>
        /// M0MOCATCD18.
        /// </summary>
        public const string M0MOCATCD18 = "M0MOCATCD18";

        /// <summary>
        /// M0MOCATCD19.
        /// </summary>
        public const string M0MOCATCD19 = "M0MOCATCD19";

        /// <summary>
        /// M0MOCATCD20.
        /// </summary>
        public const string M0MOCATCD20 = "M0MOCATCD20";

        /// <summary>
        /// M0MOCATCD21.
        /// </summary>
        public const string M0MOCATCD21 = "M0MOCATCD21";

        /// <summary>
        /// M0MOCATCD22.
        /// </summary>
        public const string M0MOCATCD22 = "M0MOCATCD22";

        /// <summary>
        /// M0MOCATCD23.
        /// </summary>
        public const string M0MOCATCD23 = "M0MOCATCD23";

        /// <summary>
        /// M0MOCATCD24.
        /// </summary>
        public const string M0MOCATCD24 = "M0MOCATCD24";

        /// <summary>
        /// M0MOCATCD25.
        /// </summary>
        public const string M0MOCATCD25 = "M0MOCATCD25";

        /// <summary>
        /// M0MOCATCD26.
        /// </summary>
        public const string M0MOCATCD26 = "M0MOCATCD26";

        /// <summary>
        /// M0MOCATCD27.
        /// </summary>
        public const string M0MOCATCD27 = "M0MOCATCD27";

        /// <summary>
        /// M0MOCATCD28.
        /// </summary>
        public const string M0MOCATCD28 = "M0MOCATCD28";

        /// <summary>
        /// M0MOCATCD29.
        /// </summary>
        public const string M0MOCATCD29 = "M0MOCATCD29";

        /// <summary>
        /// M0MOCATCD30.
        /// </summary>
        public const string M0MOCATCD30 = "M0MOCATCD30";

        /// <summary>
        /// M0USER.
        /// </summary>
        public const string M0USER = "M0USER";

        /// <summary>
        /// M0PID.
        /// </summary>
        public const string M0PID = "M0PID";

        /// <summary>
        /// M0JOBN.
        /// </summary>
        public const string M0JOBN = "M0JOBN";

        /// <summary>
        /// M0UPMJ.
        /// </summary>
        public const string M0UPMJ = "M0UPMJ";

        /// <summary>
        /// M0TDAY.
        /// </summary>
        public const string M0TDAY = "M0TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F00096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M0OBNM", "M0OBNM", JdeDataType.String, 20, true, true),
        new JdeField("M0TXKY", "M0TXKY", JdeDataType.String, 508, true, true),
        new JdeField("M0MOCATCD1", "M0MOCATCD1", JdeDataType.String, 20),
        new JdeField("M0MOCATCD2", "M0MOCATCD2", JdeDataType.String, 20),
        new JdeField("M0MOCATCD3", "M0MOCATCD3", JdeDataType.String, 20),
        new JdeField("M0MOCATCD4", "M0MOCATCD4", JdeDataType.String, 20),
        new JdeField("M0MOCATCD5", "M0MOCATCD5", JdeDataType.String, 20),
        new JdeField("M0MOCATCD6", "M0MOCATCD6", JdeDataType.String, 20),
        new JdeField("M0MOCATCD7", "M0MOCATCD7", JdeDataType.String, 20),
        new JdeField("M0MOCATCD8", "M0MOCATCD8", JdeDataType.String, 20),
        new JdeField("M0MOCATCD9", "M0MOCATCD9", JdeDataType.String, 20),
        new JdeField("M0MOCATCD10", "M0MOCATCD10", JdeDataType.String, 20),
        new JdeField("M0MOCATCD11", "M0MOCATCD11", JdeDataType.String, 20),
        new JdeField("M0MOCATCD12", "M0MOCATCD12", JdeDataType.String, 20),
        new JdeField("M0MOCATCD13", "M0MOCATCD13", JdeDataType.String, 20),
        new JdeField("M0MOCATCD14", "M0MOCATCD14", JdeDataType.String, 20),
        new JdeField("M0MOCATCD15", "M0MOCATCD15", JdeDataType.String, 20),
        new JdeField("M0MOCATCD16", "M0MOCATCD16", JdeDataType.String, 20),
        new JdeField("M0MOCATCD17", "M0MOCATCD17", JdeDataType.String, 20),
        new JdeField("M0MOCATCD18", "M0MOCATCD18", JdeDataType.String, 20),
        new JdeField("M0MOCATCD19", "M0MOCATCD19", JdeDataType.String, 20),
        new JdeField("M0MOCATCD20", "M0MOCATCD20", JdeDataType.String, 20),
        new JdeField("M0MOCATCD21", "M0MOCATCD21", JdeDataType.String, 20),
        new JdeField("M0MOCATCD22", "M0MOCATCD22", JdeDataType.String, 20),
        new JdeField("M0MOCATCD23", "M0MOCATCD23", JdeDataType.String, 20),
        new JdeField("M0MOCATCD24", "M0MOCATCD24", JdeDataType.String, 20),
        new JdeField("M0MOCATCD25", "M0MOCATCD25", JdeDataType.String, 20),
        new JdeField("M0MOCATCD26", "M0MOCATCD26", JdeDataType.String, 20),
        new JdeField("M0MOCATCD27", "M0MOCATCD27", JdeDataType.String, 20),
        new JdeField("M0MOCATCD28", "M0MOCATCD28", JdeDataType.String, 20),
        new JdeField("M0MOCATCD29", "M0MOCATCD29", JdeDataType.String, 20),
        new JdeField("M0MOCATCD30", "M0MOCATCD30", JdeDataType.String, 20),
        new JdeField("M0USER", "M0USER", JdeDataType.String, 20),
        new JdeField("M0PID", "M0PID", JdeDataType.String, 20),
        new JdeField("M0JOBN", "M0JOBN", JdeDataType.String, 20),
        new JdeField("M0UPMJ", "M0UPMJ", JdeDataType.Numeric),
        new JdeField("M0TDAY", "M0TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00096_0", "Primary Key on M0OBNM, M0TXKY", new[] { "M0OBNM", "M0TXKY" }, isUnique: true, isPrimaryKey: true)
    };
}
