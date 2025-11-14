using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B411C - .
/// </summary>
public class F76B411C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDBRNFK.
        /// </summary>
        public const string SDBRNFK = "SDBRNFK";

        /// <summary>
        /// SDFCO.
        /// </summary>
        public const string SDFCO = "SDFCO";

        /// <summary>
        /// SDN001.
        /// </summary>
        public const string SDN001 = "SDN001";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDBSER.
        /// </summary>
        public const string SDBSER = "SDBSER";

        /// <summary>
        /// SDBNNF.
        /// </summary>
        public const string SDBNNF = "SDBNNF";

        /// <summary>
        /// SDBRNFDE.
        /// </summary>
        public const string SDBRNFDE = "SDBRNFDE";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDLITM.
        /// </summary>
        public const string SDLITM = "SDLITM";

        /// <summary>
        /// SDBRD60.
        /// </summary>
        public const string SDBRD60 = "SDBRD60";

        /// <summary>
        /// SDAEXP.
        /// </summary>
        public const string SDAEXP = "SDAEXP";

        /// <summary>
        /// SDBDES.
        /// </summary>
        public const string SDBDES = "SDBDES";

        /// <summary>
        /// SDBRXISS.
        /// </summary>
        public const string SDBRXISS = "SDBRXISS";

        /// <summary>
        /// SDBBCS.
        /// </summary>
        public const string SDBBCS = "SDBBCS";

        /// <summary>
        /// SDBISS.
        /// </summary>
        public const string SDBISS = "SDBISS";

        /// <summary>
        /// SDRDOR.
        /// </summary>
        public const string SDRDOR = "SDRDOR";

        /// <summary>
        /// SDC1FU.
        /// </summary>
        public const string SDC1FU = "SDC1FU";

        /// <summary>
        /// SDC2FU.
        /// </summary>
        public const string SDC2FU = "SDC2FU";

        /// <summary>
        /// SDD1FU.
        /// </summary>
        public const string SDD1FU = "SDD1FU";

        /// <summary>
        /// SDD2FU.
        /// </summary>
        public const string SDD2FU = "SDD2FU";

        /// <summary>
        /// SDN1FU.
        /// </summary>
        public const string SDN1FU = "SDN1FU";

        /// <summary>
        /// SDN2FU.
        /// </summary>
        public const string SDN2FU = "SDN2FU";

        /// <summary>
        /// SDN3FU.
        /// </summary>
        public const string SDN3FU = "SDN3FU";

        /// <summary>
        /// SDN4FU.
        /// </summary>
        public const string SDN4FU = "SDN4FU";

        /// <summary>
        /// SDN5FU.
        /// </summary>
        public const string SDN5FU = "SDN5FU";

        /// <summary>
        /// SDN6FU.
        /// </summary>
        public const string SDN6FU = "SDN6FU";

        /// <summary>
        /// SDN7FU.
        /// </summary>
        public const string SDN7FU = "SDN7FU";

        /// <summary>
        /// SDS1FU.
        /// </summary>
        public const string SDS1FU = "SDS1FU";

        /// <summary>
        /// SDS2FU.
        /// </summary>
        public const string SDS2FU = "SDS2FU";

        /// <summary>
        /// SDS3FU.
        /// </summary>
        public const string SDS3FU = "SDS3FU";

        /// <summary>
        /// SDS4FU.
        /// </summary>
        public const string SDS4FU = "SDS4FU";

        /// <summary>
        /// SDGENLNG.
        /// </summary>
        public const string SDGENLNG = "SDGENLNG";

        /// <summary>
        /// SDTORG.
        /// </summary>
        public const string SDTORG = "SDTORG";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B411C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDBRNFK", "SDBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("SDFCO", "SDFCO", JdeDataType.String, 10),
        new JdeField("SDN001", "SDN001", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDBSER", "SDBSER", JdeDataType.String, 4),
        new JdeField("SDBNNF", "SDBNNF", JdeDataType.Numeric),
        new JdeField("SDBRNFDE", "SDBRNFDE", JdeDataType.Numeric),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLITM", "SDLITM", JdeDataType.String, 50),
        new JdeField("SDBRD60", "SDBRD60", JdeDataType.String, 120),
        new JdeField("SDAEXP", "SDAEXP", JdeDataType.Numeric),
        new JdeField("SDBDES", "SDBDES", JdeDataType.Numeric),
        new JdeField("SDBRXISS", "SDBRXISS", JdeDataType.Numeric),
        new JdeField("SDBBCS", "SDBBCS", JdeDataType.Numeric),
        new JdeField("SDBISS", "SDBISS", JdeDataType.Numeric),
        new JdeField("SDRDOR", "SDRDOR", JdeDataType.String, 2),
        new JdeField("SDC1FU", "SDC1FU", JdeDataType.String, 2),
        new JdeField("SDC2FU", "SDC2FU", JdeDataType.String, 2),
        new JdeField("SDD1FU", "SDD1FU", JdeDataType.Numeric),
        new JdeField("SDD2FU", "SDD2FU", JdeDataType.Numeric),
        new JdeField("SDN1FU", "SDN1FU", JdeDataType.Numeric),
        new JdeField("SDN2FU", "SDN2FU", JdeDataType.Numeric),
        new JdeField("SDN3FU", "SDN3FU", JdeDataType.Numeric),
        new JdeField("SDN4FU", "SDN4FU", JdeDataType.Numeric),
        new JdeField("SDN5FU", "SDN5FU", JdeDataType.Numeric),
        new JdeField("SDN6FU", "SDN6FU", JdeDataType.Numeric),
        new JdeField("SDN7FU", "SDN7FU", JdeDataType.Numeric),
        new JdeField("SDS1FU", "SDS1FU", JdeDataType.String, 60),
        new JdeField("SDS2FU", "SDS2FU", JdeDataType.String, 60),
        new JdeField("SDS3FU", "SDS3FU", JdeDataType.String, 6),
        new JdeField("SDS4FU", "SDS4FU", JdeDataType.String, 6),
        new JdeField("SDGENLNG", "SDGENLNG", JdeDataType.Numeric),
        new JdeField("SDTORG", "SDTORG", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B411C_0", "Primary Key on SDBRNFK, SDLNID", new[] { "SDBRNFK", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
