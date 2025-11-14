using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L705 - .
/// </summary>
public class FF30L705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPMPHID.
        /// </summary>
        public const string GPMPHID = "GPMPHID";

        /// <summary>
        /// GPPHID.
        /// </summary>
        public const string GPPHID = "GPPHID";

        /// <summary>
        /// GPPNCHAIN.
        /// </summary>
        public const string GPPNCHAIN = "GPPNCHAIN";

        /// <summary>
        /// GPPPTYPE.
        /// </summary>
        public const string GPPPTYPE = "GPPPTYPE";

        /// <summary>
        /// GPDIM01.
        /// </summary>
        public const string GPDIM01 = "GPDIM01";

        /// <summary>
        /// GPPAHT.
        /// </summary>
        public const string GPPAHT = "GPPAHT";

        /// <summary>
        /// GPPANG.
        /// </summary>
        public const string GPPANG = "GPPANG";

        /// <summary>
        /// GPPFLIP.
        /// </summary>
        public const string GPPFLIP = "GPPFLIP";

        /// <summary>
        /// GPPFUR1.
        /// </summary>
        public const string GPPFUR1 = "GPPFUR1";

        /// <summary>
        /// GPPFUR2.
        /// </summary>
        public const string GPPFUR2 = "GPPFUR2";

        /// <summary>
        /// GPPFUR3.
        /// </summary>
        public const string GPPFUR3 = "GPPFUR3";

        /// <summary>
        /// GPMKEY.
        /// </summary>
        public const string GPMKEY = "GPMKEY";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPUUPMJ.
        /// </summary>
        public const string GPUUPMJ = "GPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPMPHID", "GPMPHID", JdeDataType.Numeric, null, true, true),
        new JdeField("GPPHID", "GPPHID", JdeDataType.Numeric, null, true, true),
        new JdeField("GPPNCHAIN", "GPPNCHAIN", JdeDataType.String, 512, true, true),
        new JdeField("GPPPTYPE", "GPPPTYPE", JdeDataType.String, 2, true, true),
        new JdeField("GPDIM01", "GPDIM01", JdeDataType.String, 2),
        new JdeField("GPPAHT", "GPPAHT", JdeDataType.Numeric),
        new JdeField("GPPANG", "GPPANG", JdeDataType.Numeric),
        new JdeField("GPPFLIP", "GPPFLIP", JdeDataType.String, 2),
        new JdeField("GPPFUR1", "GPPFUR1", JdeDataType.String, 20),
        new JdeField("GPPFUR2", "GPPFUR2", JdeDataType.String, 20),
        new JdeField("GPPFUR3", "GPPFUR3", JdeDataType.String, 20),
        new JdeField("GPMKEY", "GPMKEY", JdeDataType.String, 30),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPUUPMJ", "GPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L705_0", "Primary Key on GPMPHID, GPPHID, GPPNCHAIN, GPPPTYPE", new[] { "GPMPHID", "GPPHID", "GPPNCHAIN", "GPPPTYPE" }, isUnique: true, isPrimaryKey: true)
    };
}
