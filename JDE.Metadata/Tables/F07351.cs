using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07351 - .
/// </summary>
public class F07351 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y1CKCN.
        /// </summary>
        public const string Y1CKCN = "Y1CKCN";

        /// <summary>
        /// Y1SCKC.
        /// </summary>
        public const string Y1SCKC = "Y1SCKC";

        /// <summary>
        /// Y1PRSI.
        /// </summary>
        public const string Y1PRSI = "Y1PRSI";

        /// <summary>
        /// Y1YST.
        /// </summary>
        public const string Y1YST = "Y1YST";

        /// <summary>
        /// Y1GPAY.
        /// </summary>
        public const string Y1GPAY = "Y1GPAY";

        /// <summary>
        /// Y1BTRN.
        /// </summary>
        public const string Y1BTRN = "Y1BTRN";

        /// <summary>
        /// Y1BKAN.
        /// </summary>
        public const string Y1BKAN = "Y1BKAN";

        /// <summary>
        /// Y1GLBA.
        /// </summary>
        public const string Y1GLBA = "Y1GLBA";

        /// <summary>
        /// Y1PREN.
        /// </summary>
        public const string Y1PREN = "Y1PREN";

        /// <summary>
        /// Y1DOCM.
        /// </summary>
        public const string Y1DOCM = "Y1DOCM";

        /// <summary>
        /// Y1CKDT.
        /// </summary>
        public const string Y1CKDT = "Y1CKDT";

        /// <summary>
        /// Y1DSIF.
        /// </summary>
        public const string Y1DSIF = "Y1DSIF";

        /// <summary>
        /// Y1PMET.
        /// </summary>
        public const string Y1PMET = "Y1PMET";

        /// <summary>
        /// Y1CADS.
        /// </summary>
        public const string Y1CADS = "Y1CADS";

        /// <summary>
        /// Y1ADFS.
        /// </summary>
        public const string Y1ADFS = "Y1ADFS";

        /// <summary>
        /// Y1ATTS.
        /// </summary>
        public const string Y1ATTS = "Y1ATTS";

        /// <summary>
        /// Y1ACPG.
        /// </summary>
        public const string Y1ACPG = "Y1ACPG";

        /// <summary>
        /// Y1ACVE.
        /// </summary>
        public const string Y1ACVE = "Y1ACVE";

        /// <summary>
        /// Y1AFPG.
        /// </summary>
        public const string Y1AFPG = "Y1AFPG";

        /// <summary>
        /// Y1AFVE.
        /// </summary>
        public const string Y1AFVE = "Y1AFVE";

        /// <summary>
        /// Y1ATPG.
        /// </summary>
        public const string Y1ATPG = "Y1ATPG";

        /// <summary>
        /// Y1ATVE.
        /// </summary>
        public const string Y1ATVE = "Y1ATVE";

        /// <summary>
        /// Y1UPMJ.
        /// </summary>
        public const string Y1UPMJ = "Y1UPMJ";

        /// <summary>
        /// Y1UPMT.
        /// </summary>
        public const string Y1UPMT = "Y1UPMT";

        /// <summary>
        /// Y1PID.
        /// </summary>
        public const string Y1PID = "Y1PID";

        /// <summary>
        /// Y1JOBN.
        /// </summary>
        public const string Y1JOBN = "Y1JOBN";

        /// <summary>
        /// Y1USER.
        /// </summary>
        public const string Y1USER = "Y1USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07351";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y1CKCN", "Y1CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1SCKC", "Y1SCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("Y1PRSI", "Y1PRSI", JdeDataType.Numeric),
        new JdeField("Y1YST", "Y1YST", JdeDataType.String, 2),
        new JdeField("Y1GPAY", "Y1GPAY", JdeDataType.Numeric),
        new JdeField("Y1BTRN", "Y1BTRN", JdeDataType.String, 40),
        new JdeField("Y1BKAN", "Y1BKAN", JdeDataType.String, 40),
        new JdeField("Y1GLBA", "Y1GLBA", JdeDataType.String, 16),
        new JdeField("Y1PREN", "Y1PREN", JdeDataType.String, 4),
        new JdeField("Y1DOCM", "Y1DOCM", JdeDataType.Numeric),
        new JdeField("Y1CKDT", "Y1CKDT", JdeDataType.Numeric),
        new JdeField("Y1DSIF", "Y1DSIF", JdeDataType.String, 2),
        new JdeField("Y1PMET", "Y1PMET", JdeDataType.String, 2),
        new JdeField("Y1CADS", "Y1CADS", JdeDataType.String, 2),
        new JdeField("Y1ADFS", "Y1ADFS", JdeDataType.String, 2),
        new JdeField("Y1ATTS", "Y1ATTS", JdeDataType.String, 2),
        new JdeField("Y1ACPG", "Y1ACPG", JdeDataType.String, 20),
        new JdeField("Y1ACVE", "Y1ACVE", JdeDataType.String, 20),
        new JdeField("Y1AFPG", "Y1AFPG", JdeDataType.String, 20),
        new JdeField("Y1AFVE", "Y1AFVE", JdeDataType.String, 20),
        new JdeField("Y1ATPG", "Y1ATPG", JdeDataType.String, 20),
        new JdeField("Y1ATVE", "Y1ATVE", JdeDataType.String, 20),
        new JdeField("Y1UPMJ", "Y1UPMJ", JdeDataType.Numeric),
        new JdeField("Y1UPMT", "Y1UPMT", JdeDataType.Numeric),
        new JdeField("Y1PID", "Y1PID", JdeDataType.String, 20),
        new JdeField("Y1JOBN", "Y1JOBN", JdeDataType.String, 20),
        new JdeField("Y1USER", "Y1USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07351_0", "Primary Key on Y1CKCN, Y1SCKC", new[] { "Y1CKCN", "Y1SCKC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07351_2", "Index on Y1DOCM", new[] { "Y1DOCM" })
    };
}
