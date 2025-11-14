using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10430A - .
/// </summary>
public class F10430A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGOTPA.
        /// </summary>
        public const string CGOTPA = "CGOTPA";

        /// <summary>
        /// CGDL01.
        /// </summary>
        public const string CGDL01 = "CGDL01";

        /// <summary>
        /// CGLV01.
        /// </summary>
        public const string CGLV01 = "CGLV01";

        /// <summary>
        /// CGOD01.
        /// </summary>
        public const string CGOD01 = "CGOD01";

        /// <summary>
        /// CGLV02.
        /// </summary>
        public const string CGLV02 = "CGLV02";

        /// <summary>
        /// CGOD02.
        /// </summary>
        public const string CGOD02 = "CGOD02";

        /// <summary>
        /// CGLV03.
        /// </summary>
        public const string CGLV03 = "CGLV03";

        /// <summary>
        /// CGOD03.
        /// </summary>
        public const string CGOD03 = "CGOD03";

        /// <summary>
        /// CGLV04.
        /// </summary>
        public const string CGLV04 = "CGLV04";

        /// <summary>
        /// CGOD04.
        /// </summary>
        public const string CGOD04 = "CGOD04";

        /// <summary>
        /// CGLV05.
        /// </summary>
        public const string CGLV05 = "CGLV05";

        /// <summary>
        /// CGOD05.
        /// </summary>
        public const string CGOD05 = "CGOD05";

        /// <summary>
        /// CGLV06.
        /// </summary>
        public const string CGLV06 = "CGLV06";

        /// <summary>
        /// CGOD06.
        /// </summary>
        public const string CGOD06 = "CGOD06";

        /// <summary>
        /// CGLV07.
        /// </summary>
        public const string CGLV07 = "CGLV07";

        /// <summary>
        /// CGOD07.
        /// </summary>
        public const string CGOD07 = "CGOD07";

        /// <summary>
        /// CGLV08.
        /// </summary>
        public const string CGLV08 = "CGLV08";

        /// <summary>
        /// CGOD08.
        /// </summary>
        public const string CGOD08 = "CGOD08";

        /// <summary>
        /// CGLV09.
        /// </summary>
        public const string CGLV09 = "CGLV09";

        /// <summary>
        /// CGOD09.
        /// </summary>
        public const string CGOD09 = "CGOD09";

        /// <summary>
        /// CGEFFF.
        /// </summary>
        public const string CGEFFF = "CGEFFF";

        /// <summary>
        /// CGNET.
        /// </summary>
        public const string CGNET = "CGNET";

        /// <summary>
        /// CGUSER.
        /// </summary>
        public const string CGUSER = "CGUSER";

        /// <summary>
        /// CGPID.
        /// </summary>
        public const string CGPID = "CGPID";

        /// <summary>
        /// CGJOBN.
        /// </summary>
        public const string CGJOBN = "CGJOBN";

        /// <summary>
        /// CGUPMJ.
        /// </summary>
        public const string CGUPMJ = "CGUPMJ";

        /// <summary>
        /// CGUPMT.
        /// </summary>
        public const string CGUPMT = "CGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10430A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGOTPA", "CGOTPA", JdeDataType.String, 6, true, true),
        new JdeField("CGDL01", "CGDL01", JdeDataType.String, 60),
        new JdeField("CGLV01", "CGLV01", JdeDataType.String, 10),
        new JdeField("CGOD01", "CGOD01", JdeDataType.String, 80),
        new JdeField("CGLV02", "CGLV02", JdeDataType.String, 10),
        new JdeField("CGOD02", "CGOD02", JdeDataType.String, 80),
        new JdeField("CGLV03", "CGLV03", JdeDataType.String, 10),
        new JdeField("CGOD03", "CGOD03", JdeDataType.String, 80),
        new JdeField("CGLV04", "CGLV04", JdeDataType.String, 10),
        new JdeField("CGOD04", "CGOD04", JdeDataType.String, 80),
        new JdeField("CGLV05", "CGLV05", JdeDataType.String, 10),
        new JdeField("CGOD05", "CGOD05", JdeDataType.String, 80),
        new JdeField("CGLV06", "CGLV06", JdeDataType.String, 10),
        new JdeField("CGOD06", "CGOD06", JdeDataType.String, 80),
        new JdeField("CGLV07", "CGLV07", JdeDataType.String, 10),
        new JdeField("CGOD07", "CGOD07", JdeDataType.String, 80),
        new JdeField("CGLV08", "CGLV08", JdeDataType.String, 10),
        new JdeField("CGOD08", "CGOD08", JdeDataType.String, 80),
        new JdeField("CGLV09", "CGLV09", JdeDataType.String, 10),
        new JdeField("CGOD09", "CGOD09", JdeDataType.String, 80),
        new JdeField("CGEFFF", "CGEFFF", JdeDataType.Numeric),
        new JdeField("CGNET", "CGNET", JdeDataType.Numeric),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGUPMT", "CGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10430A_0", "Primary Key on CGOTPA", new[] { "CGOTPA" }, isUnique: true, isPrimaryKey: true)
    };
}
