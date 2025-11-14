using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080701 - .
/// </summary>
public class F080701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LUENTPID.
        /// </summary>
        public const string LUENTPID = "LUENTPID";

        /// <summary>
        /// LUTLKUPTB.
        /// </summary>
        public const string LUTLKUPTB = "LUTLKUPTB";

        /// <summary>
        /// LUTLKUPTY.
        /// </summary>
        public const string LUTLKUPTY = "LUTLKUPTY";

        /// <summary>
        /// LUTLKUPCD.
        /// </summary>
        public const string LUTLKUPCD = "LUTLKUPCD";

        /// <summary>
        /// LUMAPID.
        /// </summary>
        public const string LUMAPID = "LUMAPID";

        /// <summary>
        /// LUSLKUPTY.
        /// </summary>
        public const string LUSLKUPTY = "LUSLKUPTY";

        /// <summary>
        /// LUSLKUPCD.
        /// </summary>
        public const string LUSLKUPCD = "LUSLKUPCD";

        /// <summary>
        /// LUMAPFLG.
        /// </summary>
        public const string LUMAPFLG = "LUMAPFLG";

        /// <summary>
        /// LUMIGFLG.
        /// </summary>
        public const string LUMIGFLG = "LUMIGFLG";

        /// <summary>
        /// LUCONFID.
        /// </summary>
        public const string LUCONFID = "LUCONFID";

        /// <summary>
        /// LUSY.
        /// </summary>
        public const string LUSY = "LUSY";

        /// <summary>
        /// LURT.
        /// </summary>
        public const string LURT = "LURT";

        /// <summary>
        /// LUDDAL.
        /// </summary>
        public const string LUDDAL = "LUDDAL";

        /// <summary>
        /// LUKY.
        /// </summary>
        public const string LUKY = "LUKY";

        /// <summary>
        /// LUUPMJ.
        /// </summary>
        public const string LUUPMJ = "LUUPMJ";

        /// <summary>
        /// LUUPMT.
        /// </summary>
        public const string LUUPMT = "LUUPMT";

        /// <summary>
        /// LUUSER.
        /// </summary>
        public const string LUUSER = "LUUSER";

        /// <summary>
        /// LUJOBN.
        /// </summary>
        public const string LUJOBN = "LUJOBN";

        /// <summary>
        /// LUPID.
        /// </summary>
        public const string LUPID = "LUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F080701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LUENTPID", "LUENTPID", JdeDataType.String, 100, true, true),
        new JdeField("LUTLKUPTB", "LUTLKUPTB", JdeDataType.String, 100, true, true),
        new JdeField("LUTLKUPTY", "LUTLKUPTY", JdeDataType.String, 100, true, true),
        new JdeField("LUTLKUPCD", "LUTLKUPCD", JdeDataType.String, 100),
        new JdeField("LUMAPID", "LUMAPID", JdeDataType.String, 100),
        new JdeField("LUSLKUPTY", "LUSLKUPTY", JdeDataType.String, 100),
        new JdeField("LUSLKUPCD", "LUSLKUPCD", JdeDataType.String, 100, true, true),
        new JdeField("LUMAPFLG", "LUMAPFLG", JdeDataType.String, 100),
        new JdeField("LUMIGFLG", "LUMIGFLG", JdeDataType.String, 100),
        new JdeField("LUCONFID", "LUCONFID", JdeDataType.Numeric, null, true, true),
        new JdeField("LUSY", "LUSY", JdeDataType.String, 8),
        new JdeField("LURT", "LURT", JdeDataType.String, 4),
        new JdeField("LUDDAL", "LUDDAL", JdeDataType.String, 80),
        new JdeField("LUKY", "LUKY", JdeDataType.String, 20),
        new JdeField("LUUPMJ", "LUUPMJ", JdeDataType.Numeric),
        new JdeField("LUUPMT", "LUUPMT", JdeDataType.Numeric),
        new JdeField("LUUSER", "LUUSER", JdeDataType.String, 20),
        new JdeField("LUJOBN", "LUJOBN", JdeDataType.String, 20),
        new JdeField("LUPID", "LUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080701_0", "Primary Key on LUENTPID, LUCONFID, LUTLKUPTB, LUTLKUPTY, LUSLKUPCD", new[] { "LUENTPID", "LUCONFID", "LUTLKUPTB", "LUTLKUPTY", "LUSLKUPCD" }, isUnique: true, isPrimaryKey: true)
    };
}
