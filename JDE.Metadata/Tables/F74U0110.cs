using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0110 - .
/// </summary>
public class F74U0110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDUKAUIT.
        /// </summary>
        public const string SDUKAUIT = "SDUKAUIT";

        /// <summary>
        /// SDUKDN.
        /// </summary>
        public const string SDUKDN = "SDUKDN";

        /// <summary>
        /// SDUKCCTY.
        /// </summary>
        public const string SDUKCCTY = "SDUKCCTY";

        /// <summary>
        /// SDUKCRN.
        /// </summary>
        public const string SDUKCRN = "SDUKCRN";

        /// <summary>
        /// SDUKNTIN.
        /// </summary>
        public const string SDUKNTIN = "SDUKNTIN";

        /// <summary>
        /// SDUKSRTD.
        /// </summary>
        public const string SDUKSRTD = "SDUKSRTD";

        /// <summary>
        /// SDUKEXPD.
        /// </summary>
        public const string SDUKEXPD = "SDUKEXPD";

        /// <summary>
        /// SDUKACTF.
        /// </summary>
        public const string SDUKACTF = "SDUKACTF";

        /// <summary>
        /// SDUKTRDA.
        /// </summary>
        public const string SDUKTRDA = "SDUKTRDA";

        /// <summary>
        /// SDUKVOCR.
        /// </summary>
        public const string SDUKVOCR = "SDUKVOCR";

        /// <summary>
        /// SDUKSCOA.
        /// </summary>
        public const string SDUKSCOA = "SDUKSCOA";

        /// <summary>
        /// SDUKSCOB.
        /// </summary>
        public const string SDUKSCOB = "SDUKSCOB";

        /// <summary>
        /// SDUKSCOC.
        /// </summary>
        public const string SDUKSCOC = "SDUKSCOC";

        /// <summary>
        /// SDUKSCOD.
        /// </summary>
        public const string SDUKSCOD = "SDUKSCOD";

        /// <summary>
        /// SDUKSCOE.
        /// </summary>
        public const string SDUKSCOE = "SDUKSCOE";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDUKAUIT", "SDUKAUIT", JdeDataType.Numeric, null, true, true),
        new JdeField("SDUKDN", "SDUKDN", JdeDataType.String, 26, true, true),
        new JdeField("SDUKCCTY", "SDUKCCTY", JdeDataType.String, 20),
        new JdeField("SDUKCRN", "SDUKCRN", JdeDataType.String, 16),
        new JdeField("SDUKNTIN", "SDUKNTIN", JdeDataType.String, 18),
        new JdeField("SDUKSRTD", "SDUKSRTD", JdeDataType.Numeric),
        new JdeField("SDUKEXPD", "SDUKEXPD", JdeDataType.Numeric),
        new JdeField("SDUKACTF", "SDUKACTF", JdeDataType.Numeric),
        new JdeField("SDUKTRDA", "SDUKTRDA", JdeDataType.Numeric),
        new JdeField("SDUKVOCR", "SDUKVOCR", JdeDataType.String, 2),
        new JdeField("SDUKSCOA", "SDUKSCOA", JdeDataType.String, 2),
        new JdeField("SDUKSCOB", "SDUKSCOB", JdeDataType.String, 2),
        new JdeField("SDUKSCOC", "SDUKSCOC", JdeDataType.String, 60),
        new JdeField("SDUKSCOD", "SDUKSCOD", JdeDataType.Numeric),
        new JdeField("SDUKSCOE", "SDUKSCOE", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0110_0", "Primary Key on SDUKAUIT, SDUKDN", new[] { "SDUKAUIT", "SDUKDN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0110_2", "Index on SDUKAUIT", new[] { "SDUKAUIT" }),
        new JdeIndex("F74U0110_3", "Index on SDUKTRDA, SDUKAUIT", new[] { "SDUKTRDA", "SDUKAUIT" }),
        new JdeIndex("F74U0110_4", "Index on SDUKAUIT, SDUKDN, SDUKCCTY", new[] { "SDUKAUIT", "SDUKDN", "SDUKCCTY" })
    };
}
