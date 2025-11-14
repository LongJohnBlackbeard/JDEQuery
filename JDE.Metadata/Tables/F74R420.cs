using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R420 - .
/// </summary>
public class F74R420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRKCO.
        /// </summary>
        public const string TRKCO = "TRKCO";

        /// <summary>
        /// TRDCT.
        /// </summary>
        public const string TRDCT = "TRDCT";

        /// <summary>
        /// TRDOC.
        /// </summary>
        public const string TRDOC = "TRDOC";

        /// <summary>
        /// TRTXA1.
        /// </summary>
        public const string TRTXA1 = "TRTXA1";

        /// <summary>
        /// TRR74RN.
        /// </summary>
        public const string TRR74RN = "TRR74RN";

        /// <summary>
        /// TRR74RVF.
        /// </summary>
        public const string TRR74RVF = "TRR74RVF";

        /// <summary>
        /// TRKCOG.
        /// </summary>
        public const string TRKCOG = "TRKCOG";

        /// <summary>
        /// TRDCTG.
        /// </summary>
        public const string TRDCTG = "TRDCTG";

        /// <summary>
        /// TRDOCG.
        /// </summary>
        public const string TRDOCG = "TRDOCG";

        /// <summary>
        /// TRDGJ.
        /// </summary>
        public const string TRDGJ = "TRDGJ";

        /// <summary>
        /// TRJELD.
        /// </summary>
        public const string TRJELD = "TRJELD";

        /// <summary>
        /// TRATXA.
        /// </summary>
        public const string TRATXA = "TRATXA";

        /// <summary>
        /// TRSTAM.
        /// </summary>
        public const string TRSTAM = "TRSTAM";

        /// <summary>
        /// TRJELF.
        /// </summary>
        public const string TRJELF = "TRJELF";

        /// <summary>
        /// TRCTXA.
        /// </summary>
        public const string TRCTXA = "TRCTXA";

        /// <summary>
        /// TRCTAM.
        /// </summary>
        public const string TRCTAM = "TRCTAM";

        /// <summary>
        /// TRR74PDJ.
        /// </summary>
        public const string TRR74PDJ = "TRR74PDJ";

        /// <summary>
        /// TRR74AVF.
        /// </summary>
        public const string TRR74AVF = "TRR74AVF";

        /// <summary>
        /// TRR74PLRC.
        /// </summary>
        public const string TRR74PLRC = "TRR74PLRC";

        /// <summary>
        /// TRR74PBF.
        /// </summary>
        public const string TRR74PBF = "TRR74PBF";

        /// <summary>
        /// TRCO.
        /// </summary>
        public const string TRCO = "TRCO";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRKCO", "TRKCO", JdeDataType.String, 10, true, true),
        new JdeField("TRDCT", "TRDCT", JdeDataType.String, 4, true, true),
        new JdeField("TRDOC", "TRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TRTXA1", "TRTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TRR74RN", "TRR74RN", JdeDataType.Numeric, null, true, true),
        new JdeField("TRR74RVF", "TRR74RVF", JdeDataType.String, 2),
        new JdeField("TRKCOG", "TRKCOG", JdeDataType.String, 10),
        new JdeField("TRDCTG", "TRDCTG", JdeDataType.String, 4),
        new JdeField("TRDOCG", "TRDOCG", JdeDataType.Numeric),
        new JdeField("TRDGJ", "TRDGJ", JdeDataType.Numeric),
        new JdeField("TRJELD", "TRJELD", JdeDataType.Numeric),
        new JdeField("TRATXA", "TRATXA", JdeDataType.Numeric),
        new JdeField("TRSTAM", "TRSTAM", JdeDataType.Numeric),
        new JdeField("TRJELF", "TRJELF", JdeDataType.Numeric),
        new JdeField("TRCTXA", "TRCTXA", JdeDataType.Numeric),
        new JdeField("TRCTAM", "TRCTAM", JdeDataType.Numeric),
        new JdeField("TRR74PDJ", "TRR74PDJ", JdeDataType.Numeric),
        new JdeField("TRR74AVF", "TRR74AVF", JdeDataType.String, 2),
        new JdeField("TRR74PLRC", "TRR74PLRC", JdeDataType.String, 8),
        new JdeField("TRR74PBF", "TRR74PBF", JdeDataType.String, 2),
        new JdeField("TRCO", "TRCO", JdeDataType.String, 10),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R420_0", "Primary Key on TRKCO, TRDCT, TRDOC, TRTXA1, TRR74RN", new[] { "TRKCO", "TRDCT", "TRDOC", "TRTXA1", "TRR74RN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R420_2", "Index on TRKCOG, TRDCTG, TRDOCG, TRDGJ, TRJELD", new[] { "TRKCOG", "TRDCTG", "TRDOCG", "TRDGJ", "TRJELD" })
    };
}
