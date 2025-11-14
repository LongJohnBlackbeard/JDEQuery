using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G82 - .
/// </summary>
public class F52G82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDIPSTYLE.
        /// </summary>
        public const string SDIPSTYLE = "SDIPSTYLE";

        /// <summary>
        /// SDIPLNID.
        /// </summary>
        public const string SDIPLNID = "SDIPLNID";

        /// <summary>
        /// SDIPSEQ.
        /// </summary>
        public const string SDIPSEQ = "SDIPSEQ";

        /// <summary>
        /// SDIPSECN.
        /// </summary>
        public const string SDIPSECN = "SDIPSECN";

        /// <summary>
        /// SDIPSECT.
        /// </summary>
        public const string SDIPSECT = "SDIPSECT";

        /// <summary>
        /// SDARGR.
        /// </summary>
        public const string SDARGR = "SDARGR";

        /// <summary>
        /// SDIPBR.
        /// </summary>
        public const string SDIPBR = "SDIPBR";

        /// <summary>
        /// SDIPTLC.
        /// </summary>
        public const string SDIPTLC = "SDIPTLC";

        /// <summary>
        /// SDPRNTU.
        /// </summary>
        public const string SDPRNTU = "SDPRNTU";

        /// <summary>
        /// SDPRNTR.
        /// </summary>
        public const string SDPRNTR = "SDPRNTR";

        /// <summary>
        /// SDSUMCUR.
        /// </summary>
        public const string SDSUMCUR = "SDSUMCUR";

        /// <summary>
        /// SDSUMCUM.
        /// </summary>
        public const string SDSUMCUM = "SDSUMCUM";

        /// <summary>
        /// SDSEQBEG.
        /// </summary>
        public const string SDSEQBEG = "SDSEQBEG";

        /// <summary>
        /// SDSEQEND.
        /// </summary>
        public const string SDSEQEND = "SDSEQEND";

        /// <summary>
        /// SDSECOPT01.
        /// </summary>
        public const string SDSECOPT01 = "SDSECOPT01";

        /// <summary>
        /// SDSECOPT02.
        /// </summary>
        public const string SDSECOPT02 = "SDSECOPT02";

        /// <summary>
        /// SDSECOPT03.
        /// </summary>
        public const string SDSECOPT03 = "SDSECOPT03";

        /// <summary>
        /// SDSECOPT04.
        /// </summary>
        public const string SDSECOPT04 = "SDSECOPT04";

        /// <summary>
        /// SDSECOPT05.
        /// </summary>
        public const string SDSECOPT05 = "SDSECOPT05";

        /// <summary>
        /// SDSECOPT06.
        /// </summary>
        public const string SDSECOPT06 = "SDSECOPT06";

        /// <summary>
        /// SDSECOPT07.
        /// </summary>
        public const string SDSECOPT07 = "SDSECOPT07";

        /// <summary>
        /// SDSECOPT08.
        /// </summary>
        public const string SDSECOPT08 = "SDSECOPT08";

        /// <summary>
        /// SDSECOPT09.
        /// </summary>
        public const string SDSECOPT09 = "SDSECOPT09";

        /// <summary>
        /// SDSECOPT10.
        /// </summary>
        public const string SDSECOPT10 = "SDSECOPT10";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDMKEY.
        /// </summary>
        public const string SDMKEY = "SDMKEY";

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
    public override string TableName => "F52G82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDIPSTYLE", "SDIPSTYLE", JdeDataType.String, 20, true, true),
        new JdeField("SDIPLNID", "SDIPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDIPSEQ", "SDIPSEQ", JdeDataType.Numeric),
        new JdeField("SDIPSECN", "SDIPSECN", JdeDataType.String, 60),
        new JdeField("SDIPSECT", "SDIPSECT", JdeDataType.String, 6),
        new JdeField("SDARGR", "SDARGR", JdeDataType.String, 8),
        new JdeField("SDIPBR", "SDIPBR", JdeDataType.String, 8),
        new JdeField("SDIPTLC", "SDIPTLC", JdeDataType.String, 8),
        new JdeField("SDPRNTU", "SDPRNTU", JdeDataType.String, 2),
        new JdeField("SDPRNTR", "SDPRNTR", JdeDataType.String, 2),
        new JdeField("SDSUMCUR", "SDSUMCUR", JdeDataType.String, 4),
        new JdeField("SDSUMCUM", "SDSUMCUM", JdeDataType.String, 4),
        new JdeField("SDSEQBEG", "SDSEQBEG", JdeDataType.Numeric),
        new JdeField("SDSEQEND", "SDSEQEND", JdeDataType.Numeric),
        new JdeField("SDSECOPT01", "SDSECOPT01", JdeDataType.String, 4),
        new JdeField("SDSECOPT02", "SDSECOPT02", JdeDataType.String, 4),
        new JdeField("SDSECOPT03", "SDSECOPT03", JdeDataType.String, 4),
        new JdeField("SDSECOPT04", "SDSECOPT04", JdeDataType.String, 4),
        new JdeField("SDSECOPT05", "SDSECOPT05", JdeDataType.String, 4),
        new JdeField("SDSECOPT06", "SDSECOPT06", JdeDataType.String, 4),
        new JdeField("SDSECOPT07", "SDSECOPT07", JdeDataType.String, 4),
        new JdeField("SDSECOPT08", "SDSECOPT08", JdeDataType.String, 4),
        new JdeField("SDSECOPT09", "SDSECOPT09", JdeDataType.String, 4),
        new JdeField("SDSECOPT10", "SDSECOPT10", JdeDataType.String, 4),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDMKEY", "SDMKEY", JdeDataType.String, 30),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G82_0", "Primary Key on SDIPSTYLE, SDIPLNID", new[] { "SDIPSTYLE", "SDIPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G82_2", "Index on SDIPSTYLE, SDIPSEQ", new[] { "SDIPSTYLE", "SDIPSEQ" }),
        new JdeIndex("F52G82_4", "Index on SDIPSTYLE, SYS_NC00030$", new[] { "SDIPSTYLE", "SYS_NC00030$" }),
        new JdeIndex("F52G82_5", "Index on SDIPSTYLE, SDIPSECT", new[] { "SDIPSTYLE", "SDIPSECT" })
    };
}
