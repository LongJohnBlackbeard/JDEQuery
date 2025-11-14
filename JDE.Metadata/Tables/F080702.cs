using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080702 - .
/// </summary>
public class F080702 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMENTNM.
        /// </summary>
        public const string EMENTNM = "EMENTNM";

        /// <summary>
        /// EMENMPID.
        /// </summary>
        public const string EMENMPID = "EMENMPID";

        /// <summary>
        /// EMSRCKEY.
        /// </summary>
        public const string EMSRCKEY = "EMSRCKEY";

        /// <summary>
        /// EMSATTY.
        /// </summary>
        public const string EMSATTY = "EMSATTY";

        /// <summary>
        /// EMSATCH.
        /// </summary>
        public const string EMSATCH = "EMSATCH";

        /// <summary>
        /// EMSATMN.
        /// </summary>
        public const string EMSATMN = "EMSATMN";

        /// <summary>
        /// EMSATDT.
        /// </summary>
        public const string EMSATDT = "EMSATDT";

        /// <summary>
        /// EMFUSGUID.
        /// </summary>
        public const string EMFUSGUID = "EMFUSGUID";

        /// <summary>
        /// EMTRKEY.
        /// </summary>
        public const string EMTRKEY = "EMTRKEY";

        /// <summary>
        /// EMTATTY.
        /// </summary>
        public const string EMTATTY = "EMTATTY";

        /// <summary>
        /// EMTATCH.
        /// </summary>
        public const string EMTATCH = "EMTATCH";

        /// <summary>
        /// EMTATMN.
        /// </summary>
        public const string EMTATMN = "EMTATMN";

        /// <summary>
        /// EMTATDT.
        /// </summary>
        public const string EMTATDT = "EMTATDT";

        /// <summary>
        /// EMCNTFLG.
        /// </summary>
        public const string EMCNTFLG = "EMCNTFLG";

        /// <summary>
        /// EMSTTUS.
        /// </summary>
        public const string EMSTTUS = "EMSTTUS";

        /// <summary>
        /// EMENTPID.
        /// </summary>
        public const string EMENTPID = "EMENTPID";

        /// <summary>
        /// EMCONFID.
        /// </summary>
        public const string EMCONFID = "EMCONFID";

        /// <summary>
        /// EMDDAL.
        /// </summary>
        public const string EMDDAL = "EMDDAL";

        /// <summary>
        /// EMSY.
        /// </summary>
        public const string EMSY = "EMSY";

        /// <summary>
        /// EMRT.
        /// </summary>
        public const string EMRT = "EMRT";

        /// <summary>
        /// EMKY.
        /// </summary>
        public const string EMKY = "EMKY";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMXRSRC.
        /// </summary>
        public const string EMXRSRC = "EMXRSRC";
    }

    /// <inheritdoc />
    public override string TableName => "F080702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMENTNM", "EMENTNM", JdeDataType.String, 80, true, true),
        new JdeField("EMENMPID", "EMENMPID", JdeDataType.Numeric),
        new JdeField("EMSRCKEY", "EMSRCKEY", JdeDataType.String, 100, true, true),
        new JdeField("EMSATTY", "EMSATTY", JdeDataType.String, 100),
        new JdeField("EMSATCH", "EMSATCH", JdeDataType.String, 2),
        new JdeField("EMSATMN", "EMSATMN", JdeDataType.Numeric),
        new JdeField("EMSATDT", "EMSATDT", JdeDataType.Numeric),
        new JdeField("EMFUSGUID", "EMFUSGUID", JdeDataType.String, 100),
        new JdeField("EMTRKEY", "EMTRKEY", JdeDataType.String, 100),
        new JdeField("EMTATTY", "EMTATTY", JdeDataType.String, 100),
        new JdeField("EMTATCH", "EMTATCH", JdeDataType.String, 2),
        new JdeField("EMTATMN", "EMTATMN", JdeDataType.Numeric),
        new JdeField("EMTATDT", "EMTATDT", JdeDataType.Numeric),
        new JdeField("EMCNTFLG", "EMCNTFLG", JdeDataType.String, 2),
        new JdeField("EMSTTUS", "EMSTTUS", JdeDataType.String, 60),
        new JdeField("EMENTPID", "EMENTPID", JdeDataType.String, 100, true, true),
        new JdeField("EMCONFID", "EMCONFID", JdeDataType.Numeric, null, true, true),
        new JdeField("EMDDAL", "EMDDAL", JdeDataType.String, 80),
        new JdeField("EMSY", "EMSY", JdeDataType.String, 8),
        new JdeField("EMRT", "EMRT", JdeDataType.String, 4),
        new JdeField("EMKY", "EMKY", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMXRSRC", "EMXRSRC", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080702_0", "Primary Key on EMENTPID, EMCONFID, EMENTNM, EMSRCKEY", new[] { "EMENTPID", "EMCONFID", "EMENTNM", "EMSRCKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
