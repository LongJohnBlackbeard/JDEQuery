using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B410H - .
/// </summary>
public class F76B410H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIBRNFK.
        /// </summary>
        public const string SIBRNFK = "SIBRNFK";

        /// <summary>
        /// SIFCO.
        /// </summary>
        public const string SIFCO = "SIFCO";

        /// <summary>
        /// SIN001.
        /// </summary>
        public const string SIN001 = "SIN001";

        /// <summary>
        /// SIDCT.
        /// </summary>
        public const string SIDCT = "SIDCT";

        /// <summary>
        /// SIBSER.
        /// </summary>
        public const string SIBSER = "SIBSER";

        /// <summary>
        /// SIMCU.
        /// </summary>
        public const string SIMCU = "SIMCU";

        /// <summary>
        /// SIOBJ.
        /// </summary>
        public const string SIOBJ = "SIOBJ";

        /// <summary>
        /// SISUB.
        /// </summary>
        public const string SISUB = "SISUB";

        /// <summary>
        /// SIBSFH.
        /// </summary>
        public const string SIBSFH = "SIBSFH";

        /// <summary>
        /// SIBRDT.
        /// </summary>
        public const string SIBRDT = "SIBRDT";

        /// <summary>
        /// SIBNNF.
        /// </summary>
        public const string SIBNNF = "SIBNNF";

        /// <summary>
        /// SIBRNFDE.
        /// </summary>
        public const string SIBRNFDE = "SIBRNFDE";

        /// <summary>
        /// SIBVTN.
        /// </summary>
        public const string SIBVTN = "SIBVTN";

        /// <summary>
        /// SILITM.
        /// </summary>
        public const string SILITM = "SILITM";

        /// <summary>
        /// SIBRD60.
        /// </summary>
        public const string SIBRD60 = "SIBRD60";

        /// <summary>
        /// SIBRNFIV.
        /// </summary>
        public const string SIBRNFIV = "SIBRNFIV";

        /// <summary>
        /// SIBRBINSS.
        /// </summary>
        public const string SIBRBINSS = "SIBRBINSS";

        /// <summary>
        /// SIBRAINSS.
        /// </summary>
        public const string SIBRAINSS = "SIBRAINSS";

        /// <summary>
        /// SIKCO.
        /// </summary>
        public const string SIKCO = "SIKCO";

        /// <summary>
        /// SIDOC.
        /// </summary>
        public const string SIDOC = "SIDOC";

        /// <summary>
        /// SISFX.
        /// </summary>
        public const string SISFX = "SISFX";

        /// <summary>
        /// SISFXE.
        /// </summary>
        public const string SISFXE = "SISFXE";

        /// <summary>
        /// SIDCTV.
        /// </summary>
        public const string SIDCTV = "SIDCTV";

        /// <summary>
        /// SIRDOR.
        /// </summary>
        public const string SIRDOR = "SIRDOR";

        /// <summary>
        /// SIC1FU.
        /// </summary>
        public const string SIC1FU = "SIC1FU";

        /// <summary>
        /// SIC2FU.
        /// </summary>
        public const string SIC2FU = "SIC2FU";

        /// <summary>
        /// SID1FU.
        /// </summary>
        public const string SID1FU = "SID1FU";

        /// <summary>
        /// SID2FU.
        /// </summary>
        public const string SID2FU = "SID2FU";

        /// <summary>
        /// SIN1FU.
        /// </summary>
        public const string SIN1FU = "SIN1FU";

        /// <summary>
        /// SIN2FU.
        /// </summary>
        public const string SIN2FU = "SIN2FU";

        /// <summary>
        /// SIN3FU.
        /// </summary>
        public const string SIN3FU = "SIN3FU";

        /// <summary>
        /// SIN4FU.
        /// </summary>
        public const string SIN4FU = "SIN4FU";

        /// <summary>
        /// SIN5FU.
        /// </summary>
        public const string SIN5FU = "SIN5FU";

        /// <summary>
        /// SIN6FU.
        /// </summary>
        public const string SIN6FU = "SIN6FU";

        /// <summary>
        /// SIN7FU.
        /// </summary>
        public const string SIN7FU = "SIN7FU";

        /// <summary>
        /// SIS1FU.
        /// </summary>
        public const string SIS1FU = "SIS1FU";

        /// <summary>
        /// SIS2FU.
        /// </summary>
        public const string SIS2FU = "SIS2FU";

        /// <summary>
        /// SIS3FU.
        /// </summary>
        public const string SIS3FU = "SIS3FU";

        /// <summary>
        /// SIS4FU.
        /// </summary>
        public const string SIS4FU = "SIS4FU";

        /// <summary>
        /// SIGENLNG.
        /// </summary>
        public const string SIGENLNG = "SIGENLNG";

        /// <summary>
        /// SITORG.
        /// </summary>
        public const string SITORG = "SITORG";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIJOBN.
        /// </summary>
        public const string SIJOBN = "SIJOBN";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B410H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIBRNFK", "SIBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("SIFCO", "SIFCO", JdeDataType.String, 10),
        new JdeField("SIN001", "SIN001", JdeDataType.Numeric),
        new JdeField("SIDCT", "SIDCT", JdeDataType.String, 4),
        new JdeField("SIBSER", "SIBSER", JdeDataType.String, 4),
        new JdeField("SIMCU", "SIMCU", JdeDataType.String, 24),
        new JdeField("SIOBJ", "SIOBJ", JdeDataType.String, 12),
        new JdeField("SISUB", "SISUB", JdeDataType.String, 16),
        new JdeField("SIBSFH", "SIBSFH", JdeDataType.Numeric),
        new JdeField("SIBRDT", "SIBRDT", JdeDataType.String, 6),
        new JdeField("SIBNNF", "SIBNNF", JdeDataType.Numeric),
        new JdeField("SIBRNFDE", "SIBRNFDE", JdeDataType.Numeric),
        new JdeField("SIBVTN", "SIBVTN", JdeDataType.Numeric),
        new JdeField("SILITM", "SILITM", JdeDataType.String, 50),
        new JdeField("SIBRD60", "SIBRD60", JdeDataType.String, 120),
        new JdeField("SIBRNFIV", "SIBRNFIV", JdeDataType.Numeric),
        new JdeField("SIBRBINSS", "SIBRBINSS", JdeDataType.Numeric),
        new JdeField("SIBRAINSS", "SIBRAINSS", JdeDataType.Numeric),
        new JdeField("SIKCO", "SIKCO", JdeDataType.String, 10),
        new JdeField("SIDOC", "SIDOC", JdeDataType.Numeric),
        new JdeField("SISFX", "SISFX", JdeDataType.String, 6),
        new JdeField("SISFXE", "SISFXE", JdeDataType.Numeric),
        new JdeField("SIDCTV", "SIDCTV", JdeDataType.String, 4),
        new JdeField("SIRDOR", "SIRDOR", JdeDataType.String, 2),
        new JdeField("SIC1FU", "SIC1FU", JdeDataType.String, 2),
        new JdeField("SIC2FU", "SIC2FU", JdeDataType.String, 2),
        new JdeField("SID1FU", "SID1FU", JdeDataType.Numeric),
        new JdeField("SID2FU", "SID2FU", JdeDataType.Numeric),
        new JdeField("SIN1FU", "SIN1FU", JdeDataType.Numeric),
        new JdeField("SIN2FU", "SIN2FU", JdeDataType.Numeric),
        new JdeField("SIN3FU", "SIN3FU", JdeDataType.Numeric),
        new JdeField("SIN4FU", "SIN4FU", JdeDataType.Numeric),
        new JdeField("SIN5FU", "SIN5FU", JdeDataType.Numeric),
        new JdeField("SIN6FU", "SIN6FU", JdeDataType.Numeric),
        new JdeField("SIN7FU", "SIN7FU", JdeDataType.Numeric),
        new JdeField("SIS1FU", "SIS1FU", JdeDataType.String, 60),
        new JdeField("SIS2FU", "SIS2FU", JdeDataType.String, 60),
        new JdeField("SIS3FU", "SIS3FU", JdeDataType.String, 6),
        new JdeField("SIS4FU", "SIS4FU", JdeDataType.String, 6),
        new JdeField("SIGENLNG", "SIGENLNG", JdeDataType.Numeric),
        new JdeField("SITORG", "SITORG", JdeDataType.String, 20),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B410H_0", "Primary Key on SIBRNFK", new[] { "SIBRNFK" }, isUnique: true, isPrimaryKey: true)
    };
}
