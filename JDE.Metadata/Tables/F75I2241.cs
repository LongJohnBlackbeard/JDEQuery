using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I2241 - .
/// </summary>
public class F75I2241 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCLNID.
        /// </summary>
        public const string VCLNID = "VCLNID";

        /// <summary>
        /// VCCO.
        /// </summary>
        public const string VCCO = "VCCO";

        /// <summary>
        /// VCMCU.
        /// </summary>
        public const string VCMCU = "VCMCU";

        /// <summary>
        /// VCDOCO.
        /// </summary>
        public const string VCDOCO = "VCDOCO";

        /// <summary>
        /// VCDCTO.
        /// </summary>
        public const string VCDCTO = "VCDCTO";

        /// <summary>
        /// VCMATH07.
        /// </summary>
        public const string VCMATH07 = "VCMATH07";

        /// <summary>
        /// VCDOC.
        /// </summary>
        public const string VCDOC = "VCDOC";

        /// <summary>
        /// VCDCT.
        /// </summary>
        public const string VCDCT = "VCDCT";

        /// <summary>
        /// VCPRRC.
        /// </summary>
        public const string VCPRRC = "VCPRRC";

        /// <summary>
        /// VCMCU1.
        /// </summary>
        public const string VCMCU1 = "VCMCU1";

        /// <summary>
        /// VCPO.
        /// </summary>
        public const string VCPO = "VCPO";

        /// <summary>
        /// VCPDCT.
        /// </summary>
        public const string VCPDCT = "VCPDCT";

        /// <summary>
        /// VCDOC1.
        /// </summary>
        public const string VCDOC1 = "VCDOC1";

        /// <summary>
        /// VCDCT1.
        /// </summary>
        public const string VCDCT1 = "VCDCT1";

        /// <summary>
        /// VCAA.
        /// </summary>
        public const string VCAA = "VCAA";

        /// <summary>
        /// VCS1FU.
        /// </summary>
        public const string VCS1FU = "VCS1FU";

        /// <summary>
        /// VCS2FU.
        /// </summary>
        public const string VCS2FU = "VCS2FU";

        /// <summary>
        /// VCN1FU.
        /// </summary>
        public const string VCN1FU = "VCN1FU";

        /// <summary>
        /// VCN2FU.
        /// </summary>
        public const string VCN2FU = "VCN2FU";

        /// <summary>
        /// VCDATF01.
        /// </summary>
        public const string VCDATF01 = "VCDATF01";

        /// <summary>
        /// VCDATF02.
        /// </summary>
        public const string VCDATF02 = "VCDATF02";

        /// <summary>
        /// VCFFG1.
        /// </summary>
        public const string VCFFG1 = "VCFFG1";

        /// <summary>
        /// VCFFG2.
        /// </summary>
        public const string VCFFG2 = "VCFFG2";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCUKID.
        /// </summary>
        public const string VCUKID = "VCUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I2241";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCLNID", "VCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VCCO", "VCCO", JdeDataType.String, 10),
        new JdeField("VCMCU", "VCMCU", JdeDataType.String, 24),
        new JdeField("VCDOCO", "VCDOCO", JdeDataType.Numeric),
        new JdeField("VCDCTO", "VCDCTO", JdeDataType.String, 4),
        new JdeField("VCMATH07", "VCMATH07", JdeDataType.Numeric),
        new JdeField("VCDOC", "VCDOC", JdeDataType.Numeric),
        new JdeField("VCDCT", "VCDCT", JdeDataType.String, 4),
        new JdeField("VCPRRC", "VCPRRC", JdeDataType.Numeric),
        new JdeField("VCMCU1", "VCMCU1", JdeDataType.String, 24),
        new JdeField("VCPO", "VCPO", JdeDataType.String, 16),
        new JdeField("VCPDCT", "VCPDCT", JdeDataType.String, 4),
        new JdeField("VCDOC1", "VCDOC1", JdeDataType.Numeric),
        new JdeField("VCDCT1", "VCDCT1", JdeDataType.String, 4),
        new JdeField("VCAA", "VCAA", JdeDataType.Numeric),
        new JdeField("VCS1FU", "VCS1FU", JdeDataType.String, 60),
        new JdeField("VCS2FU", "VCS2FU", JdeDataType.String, 60),
        new JdeField("VCN1FU", "VCN1FU", JdeDataType.Numeric),
        new JdeField("VCN2FU", "VCN2FU", JdeDataType.Numeric),
        new JdeField("VCDATF01", "VCDATF01", JdeDataType.Numeric),
        new JdeField("VCDATF02", "VCDATF02", JdeDataType.Numeric),
        new JdeField("VCFFG1", "VCFFG1", JdeDataType.String, 2),
        new JdeField("VCFFG2", "VCFFG2", JdeDataType.String, 2),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCUKID", "VCUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I2241_0", "Primary Key on VCLNID, VCUKID", new[] { "VCLNID", "VCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
