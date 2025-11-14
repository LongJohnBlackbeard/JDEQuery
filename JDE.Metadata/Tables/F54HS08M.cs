using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS08M - .
/// </summary>
public class F54HS08M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I9HSINO.
        /// </summary>
        public const string I9HSINO = "I9HSINO";

        /// <summary>
        /// I9UKID.
        /// </summary>
        public const string I9UKID = "I9UKID";

        /// <summary>
        /// I9HSIMN.
        /// </summary>
        public const string I9HSIMN = "I9HSIMN";

        /// <summary>
        /// I9HSIMT.
        /// </summary>
        public const string I9HSIMT = "I9HSIMT";

        /// <summary>
        /// I9MODDT.
        /// </summary>
        public const string I9MODDT = "I9MODDT";

        /// <summary>
        /// I9HSIEC.
        /// </summary>
        public const string I9HSIEC = "I9HSIEC";

        /// <summary>
        /// I9HSISEI.
        /// </summary>
        public const string I9HSISEI = "I9HSISEI";

        /// <summary>
        /// I9HSIENS.
        /// </summary>
        public const string I9HSIENS = "I9HSIENS";

        /// <summary>
        /// I9HSICP.
        /// </summary>
        public const string I9HSICP = "I9HSICP";

        /// <summary>
        /// I9HSIPS.
        /// </summary>
        public const string I9HSIPS = "I9HSIPS";

        /// <summary>
        /// I9ITM.
        /// </summary>
        public const string I9ITM = "I9ITM";

        /// <summary>
        /// I9DSC1.
        /// </summary>
        public const string I9DSC1 = "I9DSC1";

        /// <summary>
        /// I9HSIQS.
        /// </summary>
        public const string I9HSIQS = "I9HSIQS";

        /// <summary>
        /// I9UOM.
        /// </summary>
        public const string I9UOM = "I9UOM";

        /// <summary>
        /// I9HSIRP.
        /// </summary>
        public const string I9HSIRP = "I9HSIRP";

        /// <summary>
        /// I9HSIEVC.
        /// </summary>
        public const string I9HSIEVC = "I9HSIEVC";

        /// <summary>
        /// I9HSIQT1.
        /// </summary>
        public const string I9HSIQT1 = "I9HSIQT1";

        /// <summary>
        /// I9HSIUM1.
        /// </summary>
        public const string I9HSIUM1 = "I9HSIUM1";

        /// <summary>
        /// I9HSIQT2.
        /// </summary>
        public const string I9HSIQT2 = "I9HSIQT2";

        /// <summary>
        /// I9HSIUM2.
        /// </summary>
        public const string I9HSIUM2 = "I9HSIUM2";

        /// <summary>
        /// I9HSIQT3.
        /// </summary>
        public const string I9HSIQT3 = "I9HSIQT3";

        /// <summary>
        /// I9HSIUM3.
        /// </summary>
        public const string I9HSIUM3 = "I9HSIUM3";

        /// <summary>
        /// I9HSIV1.
        /// </summary>
        public const string I9HSIV1 = "I9HSIV1";

        /// <summary>
        /// I9HSIV2.
        /// </summary>
        public const string I9HSIV2 = "I9HSIV2";

        /// <summary>
        /// I9HSIV3.
        /// </summary>
        public const string I9HSIV3 = "I9HSIV3";

        /// <summary>
        /// I9HSIV4.
        /// </summary>
        public const string I9HSIV4 = "I9HSIV4";

        /// <summary>
        /// I9HSIV5.
        /// </summary>
        public const string I9HSIV5 = "I9HSIV5";

        /// <summary>
        /// I9URAB.
        /// </summary>
        public const string I9URAB = "I9URAB";

        /// <summary>
        /// I9URCD.
        /// </summary>
        public const string I9URCD = "I9URCD";

        /// <summary>
        /// I9URAT.
        /// </summary>
        public const string I9URAT = "I9URAT";

        /// <summary>
        /// I9URDT.
        /// </summary>
        public const string I9URDT = "I9URDT";

        /// <summary>
        /// I9URRF.
        /// </summary>
        public const string I9URRF = "I9URRF";

        /// <summary>
        /// I9USER.
        /// </summary>
        public const string I9USER = "I9USER";

        /// <summary>
        /// I9UPMJ.
        /// </summary>
        public const string I9UPMJ = "I9UPMJ";

        /// <summary>
        /// I9UPMT.
        /// </summary>
        public const string I9UPMT = "I9UPMT";

        /// <summary>
        /// I9JOBN.
        /// </summary>
        public const string I9JOBN = "I9JOBN";

        /// <summary>
        /// I9PID.
        /// </summary>
        public const string I9PID = "I9PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS08M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I9HSINO", "I9HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I9UKID", "I9UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I9HSIMN", "I9HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I9HSIMT", "I9HSIMT", JdeDataType.String, 2),
        new JdeField("I9MODDT", "I9MODDT", JdeDataType.Numeric),
        new JdeField("I9HSIEC", "I9HSIEC", JdeDataType.String, 6),
        new JdeField("I9HSISEI", "I9HSISEI", JdeDataType.String, 4),
        new JdeField("I9HSIENS", "I9HSIENS", JdeDataType.String, 4),
        new JdeField("I9HSICP", "I9HSICP", JdeDataType.Numeric),
        new JdeField("I9HSIPS", "I9HSIPS", JdeDataType.String, 12),
        new JdeField("I9ITM", "I9ITM", JdeDataType.Numeric),
        new JdeField("I9DSC1", "I9DSC1", JdeDataType.String, 60),
        new JdeField("I9HSIQS", "I9HSIQS", JdeDataType.Numeric),
        new JdeField("I9UOM", "I9UOM", JdeDataType.String, 4),
        new JdeField("I9HSIRP", "I9HSIRP", JdeDataType.String, 80),
        new JdeField("I9HSIEVC", "I9HSIEVC", JdeDataType.String, 400),
        new JdeField("I9HSIQT1", "I9HSIQT1", JdeDataType.Numeric),
        new JdeField("I9HSIUM1", "I9HSIUM1", JdeDataType.String, 4),
        new JdeField("I9HSIQT2", "I9HSIQT2", JdeDataType.Numeric),
        new JdeField("I9HSIUM2", "I9HSIUM2", JdeDataType.String, 4),
        new JdeField("I9HSIQT3", "I9HSIQT3", JdeDataType.Numeric),
        new JdeField("I9HSIUM3", "I9HSIUM3", JdeDataType.String, 4),
        new JdeField("I9HSIV1", "I9HSIV1", JdeDataType.String, 6),
        new JdeField("I9HSIV2", "I9HSIV2", JdeDataType.String, 6),
        new JdeField("I9HSIV3", "I9HSIV3", JdeDataType.String, 6),
        new JdeField("I9HSIV4", "I9HSIV4", JdeDataType.String, 6),
        new JdeField("I9HSIV5", "I9HSIV5", JdeDataType.String, 6),
        new JdeField("I9URAB", "I9URAB", JdeDataType.Numeric),
        new JdeField("I9URCD", "I9URCD", JdeDataType.String, 4),
        new JdeField("I9URAT", "I9URAT", JdeDataType.Numeric),
        new JdeField("I9URDT", "I9URDT", JdeDataType.Numeric),
        new JdeField("I9URRF", "I9URRF", JdeDataType.String, 30),
        new JdeField("I9USER", "I9USER", JdeDataType.String, 20),
        new JdeField("I9UPMJ", "I9UPMJ", JdeDataType.Numeric),
        new JdeField("I9UPMT", "I9UPMT", JdeDataType.Numeric),
        new JdeField("I9JOBN", "I9JOBN", JdeDataType.String, 20),
        new JdeField("I9PID", "I9PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS08M_0", "Primary Key on I9HSINO, I9UKID, I9HSIMN", new[] { "I9HSINO", "I9UKID", "I9HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
