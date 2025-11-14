using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07855 - .
/// </summary>
public class F07855 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AFAN8.
        /// </summary>
        public const string AFAN8 = "AFAN8";

        /// <summary>
        /// AFFNDT.
        /// </summary>
        public const string AFFNDT = "AFFNDT";

        /// <summary>
        /// AFFNDB.
        /// </summary>
        public const string AFFNDB = "AFFNDB";

        /// <summary>
        /// AFALPH.
        /// </summary>
        public const string AFALPH = "AFALPH";

        /// <summary>
        /// AFFNDU.
        /// </summary>
        public const string AFFNDU = "AFFNDU";

        /// <summary>
        /// AFFNDK.
        /// </summary>
        public const string AFFNDK = "AFFNDK";

        /// <summary>
        /// AFFDSA.
        /// </summary>
        public const string AFFDSA = "AFFDSA";

        /// <summary>
        /// AFFDSP.
        /// </summary>
        public const string AFFDSP = "AFFDSP";

        /// <summary>
        /// AFUSER.
        /// </summary>
        public const string AFUSER = "AFUSER";

        /// <summary>
        /// AFJOBN.
        /// </summary>
        public const string AFJOBN = "AFJOBN";

        /// <summary>
        /// AFPID.
        /// </summary>
        public const string AFPID = "AFPID";

        /// <summary>
        /// AFUPMJ.
        /// </summary>
        public const string AFUPMJ = "AFUPMJ";

        /// <summary>
        /// AFUPMT.
        /// </summary>
        public const string AFUPMT = "AFUPMT";

        /// <summary>
        /// AFSSRI.
        /// </summary>
        public const string AFSSRI = "AFSSRI";

        /// <summary>
        /// AFSPACAUK1.
        /// </summary>
        public const string AFSPACAUK1 = "AFSPACAUK1";

        /// <summary>
        /// AFSPACAUK2.
        /// </summary>
        public const string AFSPACAUK2 = "AFSPACAUK2";

        /// <summary>
        /// AFSPACAUK3.
        /// </summary>
        public const string AFSPACAUK3 = "AFSPACAUK3";

        /// <summary>
        /// AFSPACAUK4.
        /// </summary>
        public const string AFSPACAUK4 = "AFSPACAUK4";

        /// <summary>
        /// AFSPADAUK1.
        /// </summary>
        public const string AFSPADAUK1 = "AFSPADAUK1";

        /// <summary>
        /// AFSPADAUK2.
        /// </summary>
        public const string AFSPADAUK2 = "AFSPADAUK2";

        /// <summary>
        /// AFSPADAUK3.
        /// </summary>
        public const string AFSPADAUK3 = "AFSPADAUK3";

        /// <summary>
        /// AFSPADAUK4.
        /// </summary>
        public const string AFSPADAUK4 = "AFSPADAUK4";

        /// <summary>
        /// AFSPANAUK1.
        /// </summary>
        public const string AFSPANAUK1 = "AFSPANAUK1";

        /// <summary>
        /// AFSPANAUK2.
        /// </summary>
        public const string AFSPANAUK2 = "AFSPANAUK2";

        /// <summary>
        /// AFSPANAUK3.
        /// </summary>
        public const string AFSPANAUK3 = "AFSPANAUK3";

        /// <summary>
        /// AFSPANAUK4.
        /// </summary>
        public const string AFSPANAUK4 = "AFSPANAUK4";

        /// <summary>
        /// AFSPASAUK1.
        /// </summary>
        public const string AFSPASAUK1 = "AFSPASAUK1";

        /// <summary>
        /// AFSPASAUK2.
        /// </summary>
        public const string AFSPASAUK2 = "AFSPASAUK2";

        /// <summary>
        /// AFSPASAUK3.
        /// </summary>
        public const string AFSPASAUK3 = "AFSPASAUK3";

        /// <summary>
        /// AFSPASAUK4.
        /// </summary>
        public const string AFSPASAUK4 = "AFSPASAUK4";
    }

    /// <inheritdoc />
    public override string TableName => "F07855";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AFAN8", "AFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AFFNDT", "AFFNDT", JdeDataType.String, 2, true, true),
        new JdeField("AFFNDB", "AFFNDB", JdeDataType.String, 30, true, true),
        new JdeField("AFALPH", "AFALPH", JdeDataType.String, 80),
        new JdeField("AFFNDU", "AFFNDU", JdeDataType.String, 60),
        new JdeField("AFFNDK", "AFFNDK", JdeDataType.Numeric),
        new JdeField("AFFDSA", "AFFDSA", JdeDataType.Numeric, null, true, true),
        new JdeField("AFFDSP", "AFFDSP", JdeDataType.Numeric),
        new JdeField("AFUSER", "AFUSER", JdeDataType.String, 20),
        new JdeField("AFJOBN", "AFJOBN", JdeDataType.String, 20),
        new JdeField("AFPID", "AFPID", JdeDataType.String, 20),
        new JdeField("AFUPMJ", "AFUPMJ", JdeDataType.Numeric),
        new JdeField("AFUPMT", "AFUPMT", JdeDataType.Numeric),
        new JdeField("AFSSRI", "AFSSRI", JdeDataType.String, 2),
        new JdeField("AFSPACAUK1", "AFSPACAUK1", JdeDataType.String, 2),
        new JdeField("AFSPACAUK2", "AFSPACAUK2", JdeDataType.String, 2),
        new JdeField("AFSPACAUK3", "AFSPACAUK3", JdeDataType.String, 2),
        new JdeField("AFSPACAUK4", "AFSPACAUK4", JdeDataType.String, 2),
        new JdeField("AFSPADAUK1", "AFSPADAUK1", JdeDataType.Numeric),
        new JdeField("AFSPADAUK2", "AFSPADAUK2", JdeDataType.Numeric),
        new JdeField("AFSPADAUK3", "AFSPADAUK3", JdeDataType.Numeric),
        new JdeField("AFSPADAUK4", "AFSPADAUK4", JdeDataType.Numeric),
        new JdeField("AFSPANAUK1", "AFSPANAUK1", JdeDataType.Numeric),
        new JdeField("AFSPANAUK2", "AFSPANAUK2", JdeDataType.Numeric),
        new JdeField("AFSPANAUK3", "AFSPANAUK3", JdeDataType.Numeric),
        new JdeField("AFSPANAUK4", "AFSPANAUK4", JdeDataType.Numeric),
        new JdeField("AFSPASAUK1", "AFSPASAUK1", JdeDataType.String, 60),
        new JdeField("AFSPASAUK2", "AFSPASAUK2", JdeDataType.String, 60),
        new JdeField("AFSPASAUK3", "AFSPASAUK3", JdeDataType.String, 60),
        new JdeField("AFSPASAUK4", "AFSPASAUK4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07855_0", "Primary Key on AFAN8, AFFNDT, AFFNDB, AFFDSA", new[] { "AFAN8", "AFFNDT", "AFFNDB", "AFFDSA" }, isUnique: true, isPrimaryKey: true)
    };
}
