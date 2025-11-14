using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069056 - .
/// </summary>
public class F069056 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YOMCU.
        /// </summary>
        public const string YOMCU = "YOMCU";

        /// <summary>
        /// YOCYGR.
        /// </summary>
        public const string YOCYGR = "YOCYGR";

        /// <summary>
        /// YOETYP.
        /// </summary>
        public const string YOETYP = "YOETYP";

        /// <summary>
        /// YOETAX.
        /// </summary>
        public const string YOETAX = "YOETAX";

        /// <summary>
        /// YOSCNY.
        /// </summary>
        public const string YOSCNY = "YOSCNY";

        /// <summary>
        /// YOCTAX.
        /// </summary>
        public const string YOCTAX = "YOCTAX";

        /// <summary>
        /// YOMAIL.
        /// </summary>
        public const string YOMAIL = "YOMAIL";

        /// <summary>
        /// YOEFTB.
        /// </summary>
        public const string YOEFTB = "YOEFTB";

        /// <summary>
        /// YOEFTE.
        /// </summary>
        public const string YOEFTE = "YOEFTE";

        /// <summary>
        /// YOJBCD.
        /// </summary>
        public const string YOJBCD = "YOJBCD";

        /// <summary>
        /// YOALMH.
        /// </summary>
        public const string YOALMH = "YOALMH";

        /// <summary>
        /// YOTPCT.
        /// </summary>
        public const string YOTPCT = "YOTPCT";

        /// <summary>
        /// YOAVGD.
        /// </summary>
        public const string YOAVGD = "YOAVGD";

        /// <summary>
        /// YOFMRT.
        /// </summary>
        public const string YOFMRT = "YOFMRT";

        /// <summary>
        /// YODNMN.
        /// </summary>
        public const string YODNMN = "YODNMN";

        /// <summary>
        /// YOBDR.
        /// </summary>
        public const string YOBDR = "YOBDR";

        /// <summary>
        /// YOMNWG.
        /// </summary>
        public const string YOMNWG = "YOMNWG";

        /// <summary>
        /// YOUSER.
        /// </summary>
        public const string YOUSER = "YOUSER";

        /// <summary>
        /// YOPID.
        /// </summary>
        public const string YOPID = "YOPID";

        /// <summary>
        /// YOUPMJ.
        /// </summary>
        public const string YOUPMJ = "YOUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F069056";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YOMCU", "YOMCU", JdeDataType.String, 24, true, true),
        new JdeField("YOCYGR", "YOCYGR", JdeDataType.String, 4),
        new JdeField("YOETYP", "YOETYP", JdeDataType.String, 2),
        new JdeField("YOETAX", "YOETAX", JdeDataType.String, 40),
        new JdeField("YOSCNY", "YOSCNY", JdeDataType.String, 10),
        new JdeField("YOCTAX", "YOCTAX", JdeDataType.String, 40),
        new JdeField("YOMAIL", "YOMAIL", JdeDataType.String, 20),
        new JdeField("YOEFTB", "YOEFTB", JdeDataType.Numeric),
        new JdeField("YOEFTE", "YOEFTE", JdeDataType.Numeric),
        new JdeField("YOJBCD", "YOJBCD", JdeDataType.String, 12),
        new JdeField("YOALMH", "YOALMH", JdeDataType.String, 2),
        new JdeField("YOTPCT", "YOTPCT", JdeDataType.Numeric),
        new JdeField("YOAVGD", "YOAVGD", JdeDataType.Numeric),
        new JdeField("YOFMRT", "YOFMRT", JdeDataType.Numeric),
        new JdeField("YODNMN", "YODNMN", JdeDataType.Numeric),
        new JdeField("YOBDR", "YOBDR", JdeDataType.String, 2),
        new JdeField("YOMNWG", "YOMNWG", JdeDataType.Numeric),
        new JdeField("YOUSER", "YOUSER", JdeDataType.String, 20),
        new JdeField("YOPID", "YOPID", JdeDataType.String, 20),
        new JdeField("YOUPMJ", "YOUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069056_0", "Primary Key on YOMCU", new[] { "YOMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
