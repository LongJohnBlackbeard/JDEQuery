using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3281 - .
/// </summary>
public class F3281 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTMCU.
        /// </summary>
        public const string RTMCU = "RTMCU";

        /// <summary>
        /// RTTBLC.
        /// </summary>
        public const string RTTBLC = "RTTBLC";

        /// <summary>
        /// RTDSC1.
        /// </summary>
        public const string RTDSC1 = "RTDSC1";

        /// <summary>
        /// RTRTBT.
        /// </summary>
        public const string RTRTBT = "RTRTBT";

        /// <summary>
        /// RTNSEG.
        /// </summary>
        public const string RTNSEG = "RTNSEG";

        /// <summary>
        /// RTNVAL.
        /// </summary>
        public const string RTNVAL = "RTNVAL";

        /// <summary>
        /// RTEFFF.
        /// </summary>
        public const string RTEFFF = "RTEFFF";

        /// <summary>
        /// RTEFFT.
        /// </summary>
        public const string RTEFFT = "RTEFFT";

        /// <summary>
        /// RTURCD.
        /// </summary>
        public const string RTURCD = "RTURCD";

        /// <summary>
        /// RTURDT.
        /// </summary>
        public const string RTURDT = "RTURDT";

        /// <summary>
        /// RTURAT.
        /// </summary>
        public const string RTURAT = "RTURAT";

        /// <summary>
        /// RTURAB.
        /// </summary>
        public const string RTURAB = "RTURAB";

        /// <summary>
        /// RTURRF.
        /// </summary>
        public const string RTURRF = "RTURRF";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTTDAY.
        /// </summary>
        public const string RTTDAY = "RTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3281";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTMCU", "RTMCU", JdeDataType.String, 24, true, true),
        new JdeField("RTTBLC", "RTTBLC", JdeDataType.String, 20, true, true),
        new JdeField("RTDSC1", "RTDSC1", JdeDataType.String, 60),
        new JdeField("RTRTBT", "RTRTBT", JdeDataType.String, 2, true, true),
        new JdeField("RTNSEG", "RTNSEG", JdeDataType.Numeric),
        new JdeField("RTNVAL", "RTNVAL", JdeDataType.Numeric),
        new JdeField("RTEFFF", "RTEFFF", JdeDataType.Numeric),
        new JdeField("RTEFFT", "RTEFFT", JdeDataType.Numeric),
        new JdeField("RTURCD", "RTURCD", JdeDataType.String, 4),
        new JdeField("RTURDT", "RTURDT", JdeDataType.Numeric),
        new JdeField("RTURAT", "RTURAT", JdeDataType.Numeric),
        new JdeField("RTURAB", "RTURAB", JdeDataType.Numeric),
        new JdeField("RTURRF", "RTURRF", JdeDataType.String, 30),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTTDAY", "RTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3281_0", "Primary Key on RTTBLC, RTMCU, RTRTBT", new[] { "RTTBLC", "RTMCU", "RTRTBT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3281_2", "Index on RTRTBT, RTMCU, RTTBLC", new[] { "RTRTBT", "RTMCU", "RTTBLC" })
    };
}
