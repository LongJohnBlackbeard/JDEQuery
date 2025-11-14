using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F986112 - .
/// </summary>
public class F986112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTTOPIC.
        /// </summary>
        public const string TTTOPIC = "TTTOPIC";

        /// <summary>
        /// TTDSTYPE.
        /// </summary>
        public const string TTDSTYPE = "TTDSTYPE";

        /// <summary>
        /// TTSEQUENCEN.
        /// </summary>
        public const string TTSEQUENCEN = "TTSEQUENCEN";

        /// <summary>
        /// TTTOPICDSC.
        /// </summary>
        public const string TTTOPICDSC = "TTTOPICDSC";

        /// <summary>
        /// TTCHECKSUM.
        /// </summary>
        public const string TTCHECKSUM = "TTCHECKSUM";

        /// <summary>
        /// TTSTATUS.
        /// </summary>
        public const string TTSTATUS = "TTSTATUS";

        /// <summary>
        /// TTTOPTEXT.
        /// </summary>
        public const string TTTOPTEXT = "TTTOPTEXT";

        /// <summary>
        /// TTFFDS1.
        /// </summary>
        public const string TTFFDS1 = "TTFFDS1";

        /// <summary>
        /// TTFFDS2.
        /// </summary>
        public const string TTFFDS2 = "TTFFDS2";

        /// <summary>
        /// TTFFDS3.
        /// </summary>
        public const string TTFFDS3 = "TTFFDS3";

        /// <summary>
        /// TTFFDS4.
        /// </summary>
        public const string TTFFDS4 = "TTFFDS4";

        /// <summary>
        /// TTFFDS5.
        /// </summary>
        public const string TTFFDS5 = "TTFFDS5";

        /// <summary>
        /// TTFFDS6.
        /// </summary>
        public const string TTFFDS6 = "TTFFDS6";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTMKEY.
        /// </summary>
        public const string TTMKEY = "TTMKEY";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F986112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTTOPIC", "TTTOPIC", JdeDataType.String, 8, true, true),
        new JdeField("TTDSTYPE", "TTDSTYPE", JdeDataType.String, 2, true, true),
        new JdeField("TTSEQUENCEN", "TTSEQUENCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("TTTOPICDSC", "TTTOPICDSC", JdeDataType.String, 200),
        new JdeField("TTCHECKSUM", "TTCHECKSUM", JdeDataType.Numeric),
        new JdeField("TTSTATUS", "TTSTATUS", JdeDataType.String, 2),
        new JdeField("TTTOPTEXT", "TTTOPTEXT", JdeDataType.String),
        new JdeField("TTFFDS1", "TTFFDS1", JdeDataType.String, 20),
        new JdeField("TTFFDS2", "TTFFDS2", JdeDataType.String, 20),
        new JdeField("TTFFDS3", "TTFFDS3", JdeDataType.String, 100),
        new JdeField("TTFFDS4", "TTFFDS4", JdeDataType.String, 100),
        new JdeField("TTFFDS5", "TTFFDS5", JdeDataType.Numeric),
        new JdeField("TTFFDS6", "TTFFDS6", JdeDataType.Numeric),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTMKEY", "TTMKEY", JdeDataType.String, 30),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F986112_0", "Primary Key on TTTOPIC, TTDSTYPE, TTSEQUENCEN", new[] { "TTTOPIC", "TTDSTYPE", "TTSEQUENCEN" }, isUnique: true, isPrimaryKey: true)
    };
}
