using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3311 - .
/// </summary>
public class F3311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CNCAPM.
        /// </summary>
        public const string CNCAPM = "CNCAPM";

        /// <summary>
        /// CNMCU.
        /// </summary>
        public const string CNMCU = "CNMCU";

        /// <summary>
        /// CNCMSG.
        /// </summary>
        public const string CNCMSG = "CNCMSG";

        /// <summary>
        /// CNMSGA.
        /// </summary>
        public const string CNMSGA = "CNMSGA";

        /// <summary>
        /// CNHCLD.
        /// </summary>
        public const string CNHCLD = "CNHCLD";

        /// <summary>
        /// CNTRQT.
        /// </summary>
        public const string CNTRQT = "CNTRQT";

        /// <summary>
        /// CNUORG.
        /// </summary>
        public const string CNUORG = "CNUORG";

        /// <summary>
        /// CNUM.
        /// </summary>
        public const string CNUM = "CNUM";

        /// <summary>
        /// CNDRQJ.
        /// </summary>
        public const string CNDRQJ = "CNDRQJ";

        /// <summary>
        /// CNSTRT.
        /// </summary>
        public const string CNSTRT = "CNSTRT";

        /// <summary>
        /// CNDSC1.
        /// </summary>
        public const string CNDSC1 = "CNDSC1";

        /// <summary>
        /// CNUPMJ.
        /// </summary>
        public const string CNUPMJ = "CNUPMJ";

        /// <summary>
        /// CNUSER.
        /// </summary>
        public const string CNUSER = "CNUSER";

        /// <summary>
        /// CNJOBN.
        /// </summary>
        public const string CNJOBN = "CNJOBN";

        /// <summary>
        /// CNPID.
        /// </summary>
        public const string CNPID = "CNPID";

        /// <summary>
        /// CNUKID.
        /// </summary>
        public const string CNUKID = "CNUKID";

        /// <summary>
        /// CNWMCU.
        /// </summary>
        public const string CNWMCU = "CNWMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F3311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CNCAPM", "CNCAPM", JdeDataType.String, 2),
        new JdeField("CNMCU", "CNMCU", JdeDataType.String, 24),
        new JdeField("CNCMSG", "CNCMSG", JdeDataType.String, 2),
        new JdeField("CNMSGA", "CNMSGA", JdeDataType.String, 2),
        new JdeField("CNHCLD", "CNHCLD", JdeDataType.String, 2),
        new JdeField("CNTRQT", "CNTRQT", JdeDataType.Numeric),
        new JdeField("CNUORG", "CNUORG", JdeDataType.Numeric),
        new JdeField("CNUM", "CNUM", JdeDataType.String, 4),
        new JdeField("CNDRQJ", "CNDRQJ", JdeDataType.Numeric),
        new JdeField("CNSTRT", "CNSTRT", JdeDataType.Numeric),
        new JdeField("CNDSC1", "CNDSC1", JdeDataType.String, 60),
        new JdeField("CNUPMJ", "CNUPMJ", JdeDataType.Numeric),
        new JdeField("CNUSER", "CNUSER", JdeDataType.String, 20),
        new JdeField("CNJOBN", "CNJOBN", JdeDataType.String, 20),
        new JdeField("CNPID", "CNPID", JdeDataType.String, 20),
        new JdeField("CNUKID", "CNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CNWMCU", "CNWMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3311_0", "Primary Key on CNUKID", new[] { "CNUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3311_2", "Index on CNCAPM, CNMCU, CNWMCU, CNUM, CNHCLD, CNCMSG, CNDRQJ", new[] { "CNCAPM", "CNMCU", "CNWMCU", "CNUM", "CNHCLD", "CNCMSG", "CNDRQJ" })
    };
}
