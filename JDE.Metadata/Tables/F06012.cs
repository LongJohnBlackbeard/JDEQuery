using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06012 - .
/// </summary>
public class F06012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDAN8.
        /// </summary>
        public const string YDAN8 = "YDAN8";

        /// <summary>
        /// YDTYPP.
        /// </summary>
        public const string YDTYPP = "YDTYPP";

        /// <summary>
        /// YDDTFR.
        /// </summary>
        public const string YDDTFR = "YDDTFR";

        /// <summary>
        /// YDDTTO.
        /// </summary>
        public const string YDDTTO = "YDDTTO";

        /// <summary>
        /// YDEXR.
        /// </summary>
        public const string YDEXR = "YDEXR";

        /// <summary>
        /// YDRA01.
        /// </summary>
        public const string YDRA01 = "YDRA01";

        /// <summary>
        /// YDRA02.
        /// </summary>
        public const string YDRA02 = "YDRA02";

        /// <summary>
        /// YDRA03.
        /// </summary>
        public const string YDRA03 = "YDRA03";

        /// <summary>
        /// YDRA04.
        /// </summary>
        public const string YDRA04 = "YDRA04";

        /// <summary>
        /// YDRA05.
        /// </summary>
        public const string YDRA05 = "YDRA05";

        /// <summary>
        /// YDRA06.
        /// </summary>
        public const string YDRA06 = "YDRA06";

        /// <summary>
        /// YDRA07.
        /// </summary>
        public const string YDRA07 = "YDRA07";

        /// <summary>
        /// YDRA08.
        /// </summary>
        public const string YDRA08 = "YDRA08";

        /// <summary>
        /// YDRA09.
        /// </summary>
        public const string YDRA09 = "YDRA09";

        /// <summary>
        /// YDRA10.
        /// </summary>
        public const string YDRA10 = "YDRA10";

        /// <summary>
        /// YDRH01.
        /// </summary>
        public const string YDRH01 = "YDRH01";

        /// <summary>
        /// YDRH02.
        /// </summary>
        public const string YDRH02 = "YDRH02";

        /// <summary>
        /// YDRH03.
        /// </summary>
        public const string YDRH03 = "YDRH03";

        /// <summary>
        /// YDRH04.
        /// </summary>
        public const string YDRH04 = "YDRH04";

        /// <summary>
        /// YDRH05.
        /// </summary>
        public const string YDRH05 = "YDRH05";

        /// <summary>
        /// YDRH06.
        /// </summary>
        public const string YDRH06 = "YDRH06";

        /// <summary>
        /// YDRH07.
        /// </summary>
        public const string YDRH07 = "YDRH07";

        /// <summary>
        /// YDRH08.
        /// </summary>
        public const string YDRH08 = "YDRH08";

        /// <summary>
        /// YDRH09.
        /// </summary>
        public const string YDRH09 = "YDRH09";

        /// <summary>
        /// YDRH10.
        /// </summary>
        public const string YDRH10 = "YDRH10";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDAN8", "YDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YDTYPP", "YDTYPP", JdeDataType.String, 10, true, true),
        new JdeField("YDDTFR", "YDDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("YDDTTO", "YDDTTO", JdeDataType.Numeric),
        new JdeField("YDEXR", "YDEXR", JdeDataType.String, 60),
        new JdeField("YDRA01", "YDRA01", JdeDataType.String, 20),
        new JdeField("YDRA02", "YDRA02", JdeDataType.String, 20),
        new JdeField("YDRA03", "YDRA03", JdeDataType.String, 20),
        new JdeField("YDRA04", "YDRA04", JdeDataType.String, 20),
        new JdeField("YDRA05", "YDRA05", JdeDataType.String, 20),
        new JdeField("YDRA06", "YDRA06", JdeDataType.String, 20),
        new JdeField("YDRA07", "YDRA07", JdeDataType.String, 20),
        new JdeField("YDRA08", "YDRA08", JdeDataType.String, 20),
        new JdeField("YDRA09", "YDRA09", JdeDataType.String, 20),
        new JdeField("YDRA10", "YDRA10", JdeDataType.String, 20),
        new JdeField("YDRH01", "YDRH01", JdeDataType.Numeric),
        new JdeField("YDRH02", "YDRH02", JdeDataType.Numeric),
        new JdeField("YDRH03", "YDRH03", JdeDataType.Numeric),
        new JdeField("YDRH04", "YDRH04", JdeDataType.Numeric),
        new JdeField("YDRH05", "YDRH05", JdeDataType.Numeric),
        new JdeField("YDRH06", "YDRH06", JdeDataType.Numeric),
        new JdeField("YDRH07", "YDRH07", JdeDataType.Numeric),
        new JdeField("YDRH08", "YDRH08", JdeDataType.Numeric),
        new JdeField("YDRH09", "YDRH09", JdeDataType.Numeric),
        new JdeField("YDRH10", "YDRH10", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06012_0", "Primary Key on YDAN8, YDTYPP, YDDTFR", new[] { "YDAN8", "YDTYPP", "YDDTFR" }, isUnique: true, isPrimaryKey: true)
    };
}
