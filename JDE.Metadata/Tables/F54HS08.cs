using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS08 - .
/// </summary>
public class F54HS08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S9HSINO.
        /// </summary>
        public const string S9HSINO = "S9HSINO";

        /// <summary>
        /// S9UKID.
        /// </summary>
        public const string S9UKID = "S9UKID";

        /// <summary>
        /// S9HSIEC.
        /// </summary>
        public const string S9HSIEC = "S9HSIEC";

        /// <summary>
        /// S9HSISEI.
        /// </summary>
        public const string S9HSISEI = "S9HSISEI";

        /// <summary>
        /// S9HSIENS.
        /// </summary>
        public const string S9HSIENS = "S9HSIENS";

        /// <summary>
        /// S9HSICP.
        /// </summary>
        public const string S9HSICP = "S9HSICP";

        /// <summary>
        /// S9HSIPS.
        /// </summary>
        public const string S9HSIPS = "S9HSIPS";

        /// <summary>
        /// S9ITM.
        /// </summary>
        public const string S9ITM = "S9ITM";

        /// <summary>
        /// S9DSC1.
        /// </summary>
        public const string S9DSC1 = "S9DSC1";

        /// <summary>
        /// S9HSIQS.
        /// </summary>
        public const string S9HSIQS = "S9HSIQS";

        /// <summary>
        /// S9UOM.
        /// </summary>
        public const string S9UOM = "S9UOM";

        /// <summary>
        /// S9HSIRP.
        /// </summary>
        public const string S9HSIRP = "S9HSIRP";

        /// <summary>
        /// S9HSIEVC.
        /// </summary>
        public const string S9HSIEVC = "S9HSIEVC";

        /// <summary>
        /// S9HSIQT1.
        /// </summary>
        public const string S9HSIQT1 = "S9HSIQT1";

        /// <summary>
        /// S9HSIUM1.
        /// </summary>
        public const string S9HSIUM1 = "S9HSIUM1";

        /// <summary>
        /// S9HSIQT2.
        /// </summary>
        public const string S9HSIQT2 = "S9HSIQT2";

        /// <summary>
        /// S9HSIUM2.
        /// </summary>
        public const string S9HSIUM2 = "S9HSIUM2";

        /// <summary>
        /// S9HSIQT3.
        /// </summary>
        public const string S9HSIQT3 = "S9HSIQT3";

        /// <summary>
        /// S9HSIUM3.
        /// </summary>
        public const string S9HSIUM3 = "S9HSIUM3";

        /// <summary>
        /// S9HSIV1.
        /// </summary>
        public const string S9HSIV1 = "S9HSIV1";

        /// <summary>
        /// S9HSIV2.
        /// </summary>
        public const string S9HSIV2 = "S9HSIV2";

        /// <summary>
        /// S9HSIV3.
        /// </summary>
        public const string S9HSIV3 = "S9HSIV3";

        /// <summary>
        /// S9HSIV4.
        /// </summary>
        public const string S9HSIV4 = "S9HSIV4";

        /// <summary>
        /// S9HSIV5.
        /// </summary>
        public const string S9HSIV5 = "S9HSIV5";

        /// <summary>
        /// S9URAB.
        /// </summary>
        public const string S9URAB = "S9URAB";

        /// <summary>
        /// S9URCD.
        /// </summary>
        public const string S9URCD = "S9URCD";

        /// <summary>
        /// S9URAT.
        /// </summary>
        public const string S9URAT = "S9URAT";

        /// <summary>
        /// S9URDT.
        /// </summary>
        public const string S9URDT = "S9URDT";

        /// <summary>
        /// S9URRF.
        /// </summary>
        public const string S9URRF = "S9URRF";

        /// <summary>
        /// S9USER.
        /// </summary>
        public const string S9USER = "S9USER";

        /// <summary>
        /// S9UPMJ.
        /// </summary>
        public const string S9UPMJ = "S9UPMJ";

        /// <summary>
        /// S9UPMT.
        /// </summary>
        public const string S9UPMT = "S9UPMT";

        /// <summary>
        /// S9JOBN.
        /// </summary>
        public const string S9JOBN = "S9JOBN";

        /// <summary>
        /// S9PID.
        /// </summary>
        public const string S9PID = "S9PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S9HSINO", "S9HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S9UKID", "S9UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S9HSIEC", "S9HSIEC", JdeDataType.String, 6),
        new JdeField("S9HSISEI", "S9HSISEI", JdeDataType.String, 4),
        new JdeField("S9HSIENS", "S9HSIENS", JdeDataType.String, 4),
        new JdeField("S9HSICP", "S9HSICP", JdeDataType.Numeric),
        new JdeField("S9HSIPS", "S9HSIPS", JdeDataType.String, 12),
        new JdeField("S9ITM", "S9ITM", JdeDataType.Numeric),
        new JdeField("S9DSC1", "S9DSC1", JdeDataType.String, 60),
        new JdeField("S9HSIQS", "S9HSIQS", JdeDataType.Numeric),
        new JdeField("S9UOM", "S9UOM", JdeDataType.String, 4),
        new JdeField("S9HSIRP", "S9HSIRP", JdeDataType.String, 80),
        new JdeField("S9HSIEVC", "S9HSIEVC", JdeDataType.String, 400),
        new JdeField("S9HSIQT1", "S9HSIQT1", JdeDataType.Numeric),
        new JdeField("S9HSIUM1", "S9HSIUM1", JdeDataType.String, 4),
        new JdeField("S9HSIQT2", "S9HSIQT2", JdeDataType.Numeric),
        new JdeField("S9HSIUM2", "S9HSIUM2", JdeDataType.String, 4),
        new JdeField("S9HSIQT3", "S9HSIQT3", JdeDataType.Numeric),
        new JdeField("S9HSIUM3", "S9HSIUM3", JdeDataType.String, 4),
        new JdeField("S9HSIV1", "S9HSIV1", JdeDataType.String, 6),
        new JdeField("S9HSIV2", "S9HSIV2", JdeDataType.String, 6),
        new JdeField("S9HSIV3", "S9HSIV3", JdeDataType.String, 6),
        new JdeField("S9HSIV4", "S9HSIV4", JdeDataType.String, 6),
        new JdeField("S9HSIV5", "S9HSIV5", JdeDataType.String, 6),
        new JdeField("S9URAB", "S9URAB", JdeDataType.Numeric),
        new JdeField("S9URCD", "S9URCD", JdeDataType.String, 4),
        new JdeField("S9URAT", "S9URAT", JdeDataType.Numeric),
        new JdeField("S9URDT", "S9URDT", JdeDataType.Numeric),
        new JdeField("S9URRF", "S9URRF", JdeDataType.String, 30),
        new JdeField("S9USER", "S9USER", JdeDataType.String, 20),
        new JdeField("S9UPMJ", "S9UPMJ", JdeDataType.Numeric),
        new JdeField("S9UPMT", "S9UPMT", JdeDataType.Numeric),
        new JdeField("S9JOBN", "S9JOBN", JdeDataType.String, 20),
        new JdeField("S9PID", "S9PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS08_0", "Primary Key on S9HSINO, S9UKID", new[] { "S9HSINO", "S9UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
