using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4935 - .
/// </summary>
public class F4935 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VHCVID.
        /// </summary>
        public const string VHCVID = "VHCVID";

        /// <summary>
        /// VHEFTJ.
        /// </summary>
        public const string VHEFTJ = "VHEFTJ";

        /// <summary>
        /// VHEXDJ.
        /// </summary>
        public const string VHEXDJ = "VHEXDJ";

        /// <summary>
        /// VHDL01.
        /// </summary>
        public const string VHDL01 = "VHDL01";

        /// <summary>
        /// VHMCU.
        /// </summary>
        public const string VHMCU = "VHMCU";

        /// <summary>
        /// VHTMVT.
        /// </summary>
        public const string VHTMVT = "VHTMVT";

        /// <summary>
        /// VHMOT.
        /// </summary>
        public const string VHMOT = "VHMOT";

        /// <summary>
        /// VHDSGP.
        /// </summary>
        public const string VHDSGP = "VHDSGP";

        /// <summary>
        /// VHDSGS.
        /// </summary>
        public const string VHDSGS = "VHDSGS";

        /// <summary>
        /// VHWTUM.
        /// </summary>
        public const string VHWTUM = "VHWTUM";

        /// <summary>
        /// VHCVUM.
        /// </summary>
        public const string VHCVUM = "VHCVUM";

        /// <summary>
        /// VHVLUM.
        /// </summary>
        public const string VHVLUM = "VHVLUM";

        /// <summary>
        /// VHURCD.
        /// </summary>
        public const string VHURCD = "VHURCD";

        /// <summary>
        /// VHURDT.
        /// </summary>
        public const string VHURDT = "VHURDT";

        /// <summary>
        /// VHURAT.
        /// </summary>
        public const string VHURAT = "VHURAT";

        /// <summary>
        /// VHURAB.
        /// </summary>
        public const string VHURAB = "VHURAB";

        /// <summary>
        /// VHURRF.
        /// </summary>
        public const string VHURRF = "VHURRF";

        /// <summary>
        /// VHUSER.
        /// </summary>
        public const string VHUSER = "VHUSER";

        /// <summary>
        /// VHPID.
        /// </summary>
        public const string VHPID = "VHPID";

        /// <summary>
        /// VHJOBN.
        /// </summary>
        public const string VHJOBN = "VHJOBN";

        /// <summary>
        /// VHUPMJ.
        /// </summary>
        public const string VHUPMJ = "VHUPMJ";

        /// <summary>
        /// VHTDAY.
        /// </summary>
        public const string VHTDAY = "VHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4935";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VHCVID", "VHCVID", JdeDataType.String, 24, true, true),
        new JdeField("VHEFTJ", "VHEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VHEXDJ", "VHEXDJ", JdeDataType.Numeric),
        new JdeField("VHDL01", "VHDL01", JdeDataType.String, 60),
        new JdeField("VHMCU", "VHMCU", JdeDataType.String, 24),
        new JdeField("VHTMVT", "VHTMVT", JdeDataType.String, 2),
        new JdeField("VHMOT", "VHMOT", JdeDataType.String, 6),
        new JdeField("VHDSGP", "VHDSGP", JdeDataType.String, 6),
        new JdeField("VHDSGS", "VHDSGS", JdeDataType.String, 6),
        new JdeField("VHWTUM", "VHWTUM", JdeDataType.String, 4),
        new JdeField("VHCVUM", "VHCVUM", JdeDataType.String, 4),
        new JdeField("VHVLUM", "VHVLUM", JdeDataType.String, 4),
        new JdeField("VHURCD", "VHURCD", JdeDataType.String, 4),
        new JdeField("VHURDT", "VHURDT", JdeDataType.Numeric),
        new JdeField("VHURAT", "VHURAT", JdeDataType.Numeric),
        new JdeField("VHURAB", "VHURAB", JdeDataType.Numeric),
        new JdeField("VHURRF", "VHURRF", JdeDataType.String, 30),
        new JdeField("VHUSER", "VHUSER", JdeDataType.String, 20),
        new JdeField("VHPID", "VHPID", JdeDataType.String, 20),
        new JdeField("VHJOBN", "VHJOBN", JdeDataType.String, 20),
        new JdeField("VHUPMJ", "VHUPMJ", JdeDataType.Numeric),
        new JdeField("VHTDAY", "VHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4935_0", "Primary Key on VHCVID, VHEFTJ", new[] { "VHCVID", "VHEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
