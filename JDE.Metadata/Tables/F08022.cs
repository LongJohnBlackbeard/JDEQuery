using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08022 - .
/// </summary>
public class F08022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YZCELN.
        /// </summary>
        public const string YZCELN = "YZCELN";

        /// <summary>
        /// YZCEGN.
        /// </summary>
        public const string YZCEGN = "YZCEGN";

        /// <summary>
        /// YZCEAN.
        /// </summary>
        public const string YZCEAN = "YZCEAN";

        /// <summary>
        /// YZSEX.
        /// </summary>
        public const string YZSEX = "YZSEX";

        /// <summary>
        /// YZCESL.
        /// </summary>
        public const string YZCESL = "YZCESL";

        /// <summary>
        /// YZCENC.
        /// </summary>
        public const string YZCENC = "YZCENC";

        /// <summary>
        /// YZCEOG.
        /// </summary>
        public const string YZCEOG = "YZCEOG";

        /// <summary>
        /// YZCEPV.
        /// </summary>
        public const string YZCEPV = "YZCEPV";

        /// <summary>
        /// YZCECM.
        /// </summary>
        public const string YZCECM = "YZCECM";

        /// <summary>
        /// YZCESI.
        /// </summary>
        public const string YZCESI = "YZCESI";

        /// <summary>
        /// YZCEES.
        /// </summary>
        public const string YZCEES = "YZCEES";

        /// <summary>
        /// YZCEVM.
        /// </summary>
        public const string YZCEVM = "YZCEVM";

        /// <summary>
        /// YZCEAB.
        /// </summary>
        public const string YZCEAB = "YZCEAB";

        /// <summary>
        /// YZHM04.
        /// </summary>
        public const string YZHM04 = "YZHM04";

        /// <summary>
        /// YZCEHD.
        /// </summary>
        public const string YZCEHD = "YZCEHD";

        /// <summary>
        /// YZCETD.
        /// </summary>
        public const string YZCETD = "YZCETD";

        /// <summary>
        /// YZCEP1.
        /// </summary>
        public const string YZCEP1 = "YZCEP1";

        /// <summary>
        /// YZCEP2.
        /// </summary>
        public const string YZCEP2 = "YZCEP2";

        /// <summary>
        /// YZCEP3.
        /// </summary>
        public const string YZCEP3 = "YZCEP3";

        /// <summary>
        /// YZCEP4.
        /// </summary>
        public const string YZCEP4 = "YZCEP4";

        /// <summary>
        /// YZCECD.
        /// </summary>
        public const string YZCECD = "YZCECD";

        /// <summary>
        /// YZCEDV.
        /// </summary>
        public const string YZCEDV = "YZCEDV";
    }

    /// <inheritdoc />
    public override string TableName => "F08022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YZCELN", "YZCELN", JdeDataType.String, 40),
        new JdeField("YZCEGN", "YZCEGN", JdeDataType.String, 30),
        new JdeField("YZCEAN", "YZCEAN", JdeDataType.String, 18, true, true),
        new JdeField("YZSEX", "YZSEX", JdeDataType.String, 2),
        new JdeField("YZCESL", "YZCESL", JdeDataType.String, 12),
        new JdeField("YZCENC", "YZCENC", JdeDataType.String, 8),
        new JdeField("YZCEOG", "YZCEOG", JdeDataType.String, 4),
        new JdeField("YZCEPV", "YZCEPV", JdeDataType.String, 4),
        new JdeField("YZCECM", "YZCECM", JdeDataType.String, 4),
        new JdeField("YZCESI", "YZCESI", JdeDataType.String, 8),
        new JdeField("YZCEES", "YZCEES", JdeDataType.String, 2),
        new JdeField("YZCEVM", "YZCEVM", JdeDataType.String, 2),
        new JdeField("YZCEAB", "YZCEAB", JdeDataType.String, 2),
        new JdeField("YZHM04", "YZHM04", JdeDataType.String, 2),
        new JdeField("YZCEHD", "YZCEHD", JdeDataType.String, 16),
        new JdeField("YZCETD", "YZCETD", JdeDataType.String, 16),
        new JdeField("YZCEP1", "YZCEP1", JdeDataType.String, 16),
        new JdeField("YZCEP2", "YZCEP2", JdeDataType.String, 16),
        new JdeField("YZCEP3", "YZCEP3", JdeDataType.String, 16),
        new JdeField("YZCEP4", "YZCEP4", JdeDataType.String, 16),
        new JdeField("YZCECD", "YZCECD", JdeDataType.String, 16),
        new JdeField("YZCEDV", "YZCEDV", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08022_0", "Primary Key on YZCEAN", new[] { "YZCEAN" }, isUnique: true, isPrimaryKey: true)
    };
}
